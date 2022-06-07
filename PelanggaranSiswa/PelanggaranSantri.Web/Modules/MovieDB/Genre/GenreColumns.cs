using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MovieDB.Columns
{
    [ColumnsScript("MovieDB.Genre")]
    [BasedOnRow(typeof(GenreRow), CheckNames = true)]
    public class GenreColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int GenreId { get; set; }
        [EditLink]
        public string Name { get; set; }
    }
}