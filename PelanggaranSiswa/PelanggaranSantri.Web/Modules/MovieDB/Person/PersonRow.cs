using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace PelanggaranSantri.MovieDB
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("Person")]
    [DisplayName("Person"), InstanceName("Person")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("MovieDB.Person")]
    public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Person Id"), Identity, IdProperty]
        public int? PersonId
        {
            get => fields.PersonId[this];
            set => fields.PersonId[this] = value;
        }

        [DisplayName("First Name"), Size(50), NotNull]
        public string FirstName
        {
            get => fields.FirstName[this];
            set => fields.FirstName[this] = value;
        }

        [DisplayName("Lastname"), Size(50), NotNull]
        public string Lastname
        {
            get => fields.Lastname[this];
            set => fields.Lastname[this] = value;
        }

        [DisplayName("Full Name")]
        [Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))"), QuickSearch, NameProperty]
        public String Fullname
        {
            get => fields.Fullname[this];
            set => fields.Fullname[this] = value;
        }

        [DisplayName("Birth Date")]
        public DateTime? BirthDate
        {
            get => fields.BirthDate[this];
            set => fields.BirthDate[this] = value;
        }

        [DisplayName("Birth Place"), Size(100)]
        public string BirthPlace
        {
            get => fields.BirthPlace[this];
            set => fields.BirthPlace[this] = value;
        }

        [DisplayName("Gender")]
        public Gender? Gender
        {
            get => (Gender?)fields.Gender[this];
            set => fields.Gender[this] = (Int32?)value;
        }

        [DisplayName("Height")]
        public int? Height
        {
            get => fields.Height[this];
            set => fields.Height[this] = value;
        }

        [DisplayName("Primary Image"), Size(100),
        ImageUploadEditor(FilenameFormat = "Person/PrimaryImage/~")]
        public string PrimaryImage
        {
            get => fields.PrimaryImage[this];
            set => fields.PrimaryImage[this] = value;
        }

        [DisplayName("Gallery Images"),
        MultipleImageUploadEditor(FilenameFormat = "Person/GalleryImages/~")]
        public string GalleryImages
        {
            get => fields.GalleryImages[this];
            set => fields.GalleryImages[this] = value;
        }

        public PersonRow()
            : base()
        {
        }

        public PersonRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PersonId;
            public StringField FirstName;
            public StringField Lastname;
            public StringField Fullname;
            public DateTimeField BirthDate;
            public StringField BirthPlace;
            public Int32Field Gender;
            public Int32Field Height;
            public StringField PrimaryImage;
            public StringField GalleryImages;
        }
    }
}
