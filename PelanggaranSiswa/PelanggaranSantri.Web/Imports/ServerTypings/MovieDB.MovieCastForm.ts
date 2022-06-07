namespace PelanggaranSantri.MovieDB {
    export interface MovieCastForm {
        PersonId: Serenity.LookupEditor;
        Character: Serenity.StringEditor;
    }

    export class MovieCastForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.MovieCast';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieCastForm.init)  {
                MovieCastForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(MovieCastForm, [
                    'PersonId', w0,
                    'Character', w1
                ]);
            }
        }
    }
}
