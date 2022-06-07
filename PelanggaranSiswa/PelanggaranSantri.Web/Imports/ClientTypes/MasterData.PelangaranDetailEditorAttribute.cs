using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PelanggaranSantri.MasterData
{
    public partial class PelangaranDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "PelanggaranSantri.MasterData.PelangaranDetailEditor";

        public PelangaranDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
