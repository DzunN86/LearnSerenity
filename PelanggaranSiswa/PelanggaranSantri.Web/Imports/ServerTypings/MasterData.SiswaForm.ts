namespace PelanggaranSantri.MasterData {
    export interface SiswaForm {
        Nis: Serenity.IntegerEditor;
        Nama: Serenity.StringEditor;
        KotaAsal: Serenity.StringEditor;
        TglLahir: Serenity.DateEditor;
        Umur: Serenity.IntegerEditor;
        DetailPelanggaran: PelanggaranDetailEditor;
    }

    export class SiswaForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Siswa';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SiswaForm.init)  {
                SiswaForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = PelanggaranDetailEditor;

                Q.initFormType(SiswaForm, [
                    'Nis', w0,
                    'Nama', w1,
                    'KotaAsal', w1,
                    'TglLahir', w2,
                    'Umur', w0,
                    'DetailPelanggaran', w3
                ]);
            }
        }
    }
}
