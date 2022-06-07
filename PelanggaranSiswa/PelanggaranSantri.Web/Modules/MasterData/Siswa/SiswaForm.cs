using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MasterData.Forms
{
    [FormScript("MasterData.Siswa")]
    [BasedOnRow(typeof(SiswaRow), CheckNames = true)]
    public class SiswaForm
    {
        public int Nis { get; set; }
        public string Nama { get; set; }
        public string KotaAsal { get; set; }
        public DateTime TglLahir { get; set; }
        public int Umur { get; set; }
        [Category("Detail Pelanggaran")]
        [PelanggaranDetailEditor]
        public List<PelanggaranRow> DetailPelanggaran { get; set; }
    }
}