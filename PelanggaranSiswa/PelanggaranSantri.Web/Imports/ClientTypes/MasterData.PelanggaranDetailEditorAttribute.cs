using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PelanggaranSantri.MasterData
{
    public partial class PelanggaranDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "PelanggaranSantri.MasterData.PelanggaranDetailEditor";

        public PelanggaranDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
