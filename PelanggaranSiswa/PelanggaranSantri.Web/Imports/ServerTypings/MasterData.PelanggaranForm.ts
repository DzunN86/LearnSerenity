namespace PelanggaranSantri.MasterData {
    export interface PelanggaranForm {
        Pelanggaran: Serenity.StringEditor;
        TglPelanggaran: Serenity.DateEditor;
        Keterangan: Serenity.StringEditor;
    }

    export class PelanggaranForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Pelanggaran';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PelanggaranForm.init)  {
                PelanggaranForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(PelanggaranForm, [
                    'Pelanggaran', w0,
                    'TglPelanggaran', w1,
                    'Keterangan', w0
                ]);
            }
        }
    }
}
