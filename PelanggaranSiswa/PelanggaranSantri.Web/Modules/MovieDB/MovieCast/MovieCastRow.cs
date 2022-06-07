using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace PelanggaranSantri.MovieDB
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("MovieCast")]
    [DisplayName("Movie Cast"), InstanceName("Movie Cast")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieCastRow : Row<MovieCastRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Cast Id"), Identity, IdProperty]
        public int? MovieCastId
        {
            get => fields.MovieCastId[this];
            set => fields.MovieCastId[this] = value;
        }

        [DisplayName("Movie"), NotNull, ForeignKey("Movie", "MovieId"), LeftJoin("jMovie"), TextualField("MovieTitle")]
        public int? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Actor/Actress"), NotNull, ForeignKey("Person", "PersonId")]
        [LeftJoin("jPerson"), TextualField("PersonFirstName")]
        [LookupEditor(typeof(PersonRow))]
        public Int32? PersonId
        {
            get => fields.PersonId[this];
            set => fields.PersonId[this] = value;
        }

        [DisplayName("Character"), Size(50), QuickSearch, NameProperty]
        public string Character
        {
            get => fields.Character[this];
            set => fields.Character[this] = value;
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

        [DisplayName("Person First Name"), Expression("jPerson.[FirstName]")]
        public string PersonFirstName
        {
            get => fields.PersonFirstName[this];
            set => fields.PersonFirstName[this] = value;
        }

        [DisplayName("Person Lastname"), Expression("jPerson.[Lastname]")]
        public string PersonLastname
        {
            get => fields.PersonLastname[this];
            set => fields.PersonLastname[this] = value;
        }

        [DisplayName("Actor/Actress")] 
        [Expression("CONCAT(jPerson.[FirstName], CONCAT(' ', jPerson.[LastName]))")]
        public String PersonFullname
        {
            get => fields.PersonFullname[this];
            set => fields.PersonFullname[this] = value;
        }

        [DisplayName("Person Birth Date"), Expression("jPerson.[BirthDate]")]
        public DateTime? PersonBirthDate
        {
            get => fields.PersonBirthDate[this];
            set => fields.PersonBirthDate[this] = value;
        }

        [DisplayName("Person Birth Place"), Expression("jPerson.[BirthPlace]")]
        public string PersonBirthPlace
        {
            get => fields.PersonBirthPlace[this];
            set => fields.PersonBirthPlace[this] = value;
        }

        [DisplayName("Person Gender"), Expression("jPerson.[Gender]")]
        public int? PersonGender
        {
            get => fields.PersonGender[this];
            set => fields.PersonGender[this] = value;
        }

        [DisplayName("Person Height"), Expression("jPerson.[Height]")]
        public int? PersonHeight
        {
            get => fields.PersonHeight[this];
            set => fields.PersonHeight[this] = value;
        }

        public MovieCastRow()
            : base()
        {
        }

        public MovieCastRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieCastId;
            public Int32Field MovieId;
            public Int32Field PersonId;
            public StringField Character;

            public StringField MovieTitle;
            public StringField MovieDescription;
            public StringField MovieStoryline;
            public Int32Field MovieYear;
            public DateTimeField MovieReleaseDate;
            public Int32Field MovieRuntime;
            public Int32Field MovieKind;

            public StringField PersonFirstName;
            public StringField PersonLastname;
            public DateTimeField PersonBirthDate;
            public StringField PersonBirthPlace;
            public Int32Field PersonGender;
            public Int32Field PersonHeight;
            public StringField PersonFullname;
        }
    }
}
