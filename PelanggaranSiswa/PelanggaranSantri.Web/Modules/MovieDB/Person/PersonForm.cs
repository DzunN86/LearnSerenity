using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MovieDB.Forms
{
    [FormScript("MovieDB.Person")]
    [BasedOnRow(typeof(PersonRow), CheckNames = true)]
    public class PersonForm
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public String PrimaryImage { get; set; }
        public String GalleryImages { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Int32 Gender { get; set; }
        public int Height { get; set; }
    }
}