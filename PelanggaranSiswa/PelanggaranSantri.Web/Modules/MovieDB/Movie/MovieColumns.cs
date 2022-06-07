using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MovieDB.Columns
{
    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int MovieId { get; set; }
        [EditLink]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Storyline { get; set; }
        public int Year { get; set; }
        [DisplayFormat("dd/MM/yyyy"), DisplayName("Release Date"), Width(150)]
        public DateTime ReleaseDate { get; set; }
        [Width(100), QuickFilter]
        public MovieKind Kind { get; set; }
        [Width(200), GenreListFormatter, QuickFilter]
        public List<Int32> GenreList { get; set; }
        [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
        public int Runtime { get; set; }
    }
}