using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MasterData.Columns
{
    [ColumnsScript("MasterData.Pelanggaran")]
    [BasedOnRow(typeof(PelanggaranRow), CheckNames = true)]
    public class PelanggaranColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Hidden]
        public int Id { get; set; }
        [EditLink]
        public int IdSiswa { get; set; }
        public string Pelanggaran { get; set; }
        public DateTime TglPelanggaran { get; set; }
        public string Keterangan { get; set; }
    }
}