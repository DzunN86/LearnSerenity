namespace PelanggaranSantri.MovieDB {
    export interface GenreForm {
        Name: Serenity.StringEditor;
    }

    export class GenreForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.Genre';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GenreForm.init)  {
                GenreForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(GenreForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
