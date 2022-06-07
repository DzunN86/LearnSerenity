using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MovieDB.Forms
{
    [FormScript("MovieDB.MovieCast")]
    [BasedOnRow(typeof(MovieCastRow), CheckNames = true)]
    public class MovieCastForm
    {
        public int PersonId { get; set; }
        public string Character { get; set; }
    }
}