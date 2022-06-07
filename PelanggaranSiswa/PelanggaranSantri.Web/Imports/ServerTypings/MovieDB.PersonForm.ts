namespace PelanggaranSantri.MovieDB {
    export interface PersonForm {
        FirstName: Serenity.StringEditor;
        Lastname: Serenity.StringEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
        GalleryImages: Serenity.MultipleImageUploadEditor;
        BirthDate: Serenity.DateEditor;
        BirthPlace: Serenity.StringEditor;
        Gender: Serenity.EnumEditor;
        Height: Serenity.IntegerEditor;
    }

    export class PersonForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.Person';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PersonForm.init)  {
                PersonForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.MultipleImageUploadEditor;
                var w3 = s.DateEditor;
                var w4 = s.EnumEditor;
                var w5 = s.IntegerEditor;

                Q.initFormType(PersonForm, [
                    'FirstName', w0,
                    'Lastname', w0,
                    'PrimaryImage', w1,
                    'GalleryImages', w2,
                    'BirthDate', w3,
                    'BirthPlace', w0,
                    'Gender', w4,
                    'Height', w5
                ]);
            }
        }
    }
}
