using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace PelanggaranSantri.MasterData
{
    [ConnectionKey("MasterData"), Module("MasterData"), TableName("pelanggaran")]
    [DisplayName("Pelanggaran"), InstanceName("Pelanggaran")]
    [ReadPermission("MasterData:View")]
    [ModifyPermission("MasterData:Modify")]
    public sealed class PelanggaranRow : Row<PelanggaranRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Pelanggaran"), Size(50), QuickSearch, NameProperty]
        public string Pelanggaran
        {
            get => fields.Pelanggaran[this];
            set => fields.Pelanggaran[this] = value;
        }

        [DisplayName("Tgl Pelanggaran")]
        public DateTime? TglPelanggaran
        {
            get => fields.TglPelanggaran[this];
            set => fields.TglPelanggaran[this] = value;
        }

        [DisplayName("Keterangan"), Size(50)]
        public string Keterangan
        {
            get => fields.Keterangan[this];
            set => fields.Keterangan[this] = value;
        }

        [DisplayName("IdSiswa"), Column("IdSiswa")]
        public Int32? IdSiswa
        {
            get => fields.IdSiswa[this];
            set => fields.IdSiswa[this] = value;
        }

        public PelanggaranRow()
            : base()
        {
        }

        public PelanggaranRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Pelanggaran;
            public DateTimeField TglPelanggaran;
            public StringField Keterangan;
            public Int32Field IdSiswa;
        }
    }
}
