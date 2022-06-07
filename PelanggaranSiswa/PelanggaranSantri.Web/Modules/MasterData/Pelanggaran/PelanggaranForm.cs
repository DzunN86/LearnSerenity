using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace PelanggaranSantri.MasterData.Forms
{
    [FormScript("MasterData.Pelanggaran")]
    [BasedOnRow(typeof(PelanggaranRow), CheckNames = true)]
    public class PelanggaranForm
    {
        public string Pelanggaran { get; set; }
        public DateTime TglPelanggaran { get; set; }
        public string Keterangan { get; set; }
    }
}