using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MasterData.Columns
{
    [ColumnsScript("MasterData.Siswa")]
    [BasedOnRow(typeof(SiswaRow), CheckNames = true)]
    public class SiswaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public int Id { get; set; }
        public int Nis { get; set; }
        [EditLink]
        public string Nama { get; set; }
        public string KotaAsal { get; set; }
        public DateTime TglLahir { get; set; }
        public int Umur { get; set; }
    }
}