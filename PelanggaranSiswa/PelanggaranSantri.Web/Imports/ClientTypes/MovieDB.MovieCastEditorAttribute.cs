using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PelanggaranSantri.MovieDB
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "PelanggaranSantri.MovieDB.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}
