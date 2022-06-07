using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;

namespace PelanggaranSantri.MovieDB
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("Movie")]
    [DisplayName("Movies"), InstanceName("Movie")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity, IdProperty]
        public int? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Description"), Size(1000), QuickSearch]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Storyline"), Size(2000), QuickSearch]
        public string Storyline
        {
            get => fields.Storyline[this];
            set => fields.Storyline[this] = value;
        }

        [DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
        public int? Year
        {
            get => fields.Year[this];
            set => fields.Year[this] = value;
        }

        [DisplayName("Release Date")]
        public DateTime? ReleaseDate
        {
            get => fields.ReleaseDate[this];
            set => fields.ReleaseDate[this] = value;
        }

        [DisplayName("Runtime (mins)")]
        public int? Runtime
        {
            get => fields.Runtime[this];
            set => fields.Runtime[this] = value;
        }

        [DisplayName("Kind"), NotNull]
        public MovieKind? Kind
        {
            get => (MovieKind?)fields.Kind[this];
            set => fields.Kind[this] = (Int32?)value;
        }

        [DisplayName("Genres")]
        [LookupEditor(typeof(GenreRow), Multiple = true, InplaceAdd = true), NotMapped]
        [LinkingSetRelation(typeof(MovieGenresRow), "MovieId", "GenreId")]
        public List<Int32> GenreList
        {
            get => fields.GenreList[this];
            set => fields.GenreList[this] = value;
        }

        [MasterDetailRelation(foreignKey: "MovieId", IncludeColumns = "PersonFullname")]
        [DisplayName("Cast List"), NotMapped]
        public List<MovieCastRow> CastList
        {
            get => fields.CastList[this];
            set => fields.CastList[this] = value;
        }

        [DisplayName("Primary Image"), Size(100),
        ImageUploadEditor(FilenameFormat = "Movie/PrimaryImage/~")]
        public string PrimaryImage
        {
            get => fields.PrimaryImage[this];
            set => fields.PrimaryImage[this] = value;
        }

        [DisplayName("Gallery Images"),
        MultipleImageUploadEditor(FilenameFormat = "Movie/GalleryImages/~")]
        public string GalleryImages
        {
            get => fields.GalleryImages[this];
            set => fields.GalleryImages[this] = value;
        }

        public MovieRow()
            : base()
        {
        }

        public MovieRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public Int32Field Kind;
            public ListField<Int32> GenreList;
            public RowListField<MovieCastRow> CastList;
            public StringField PrimaryImage;
            public StringField GalleryImages;
        }
    }
}
