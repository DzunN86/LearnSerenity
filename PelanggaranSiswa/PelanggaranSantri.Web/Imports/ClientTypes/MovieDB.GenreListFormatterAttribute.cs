using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PelanggaranSantri.MovieDB
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "PelanggaranSantri.MovieDB.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
