using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace PelanggaranSantri.MovieDB
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("MovieGenres")]
    [DisplayName("Movie Genres"), InstanceName("Movie Genres")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieGenresRow : Row<MovieGenresRow.RowFields>, IIdRow
    {
        [DisplayName("Movie Genre Id"), Identity, IdProperty]
        public int? MovieGenreId
        {
            get => fields.MovieGenreId[this];
            set => fields.MovieGenreId[this] = value;
        }

        [DisplayName("Movie"), NotNull, ForeignKey("Movie", "MovieId"), LeftJoin("jMovie"), TextualField("MovieTitle")]
        public int? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Genre"), NotNull, ForeignKey("Genre", "GenreId"), LeftJoin("jGenre"), TextualField("GenreName")]
        public int? GenreId
        {
            get => fields.GenreId[this];
            set => fields.GenreId[this] = value;
        }

        [DisplayName("Movie Title"), Expression("jMovie.[Title]")]
        public string MovieTitle
        {
            get => fields.MovieTitle[this];
            set => fields.MovieTitle[this] = value;
        }

        [DisplayName("Movie Description"), Expression("jMovie.[Description]")]
        public string MovieDescription
        {
            get => fields.MovieDescription[this];
            set => fields.MovieDescription[this] = value;
        }

        [DisplayName("Movie Storyline"), Expression("jMovie.[Storyline]")]
        public string MovieStoryline
        {
            get => fields.MovieStoryline[this];
            set => fields.MovieStoryline[this] = value;
        }

        [DisplayName("Movie Year"), Expression("jMovie.[Year]")]
        public int? MovieYear
        {
            get => fields.MovieYear[this];
            set => fields.MovieYear[this] = value;
        }

        [DisplayName("Movie Release Date"), Expression("jMovie.[ReleaseDate]")]
        public DateTime? MovieReleaseDate
        {
            get => fields.MovieReleaseDate[this];
            set => fields.MovieReleaseDate[this] = value;
        }

        [DisplayName("Movie Runtime"), Expression("jMovie.[Runtime]")]
        public int? MovieRuntime
        {
            get => fields.MovieRuntime[this];
            set => fields.MovieRuntime[this] = value;
        }

        [DisplayName("Movie Kind"), Expression("jMovie.[Kind]")]
        public int? MovieKind
        {
            get => fields.MovieKind[this];
            set => fields.MovieKind[this] = value;
        }

        [DisplayName("Genre Name"), Expression("jGenre.[Name]")]
        public string GenreName
        {
            get => fields.GenreName[this];
            set => fields.GenreName[this] = value;
        }

        public MovieGenresRow()
            : base()
        {
        }

        public MovieGenresRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieGenreId;
            public Int32Field MovieId;
            public Int32Field GenreId;

            public StringField MovieTitle;
            public StringField MovieDescription;
            public StringField MovieStoryline;
            public Int32Field MovieYear;
            public DateTimeField MovieReleaseDate;
            public Int32Field MovieRuntime;
            public Int32Field MovieKind;

            public StringField GenreName;
        }
    }
}
