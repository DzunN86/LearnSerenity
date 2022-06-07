namespace PelanggaranSantri.MovieDB {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        CastList: MovieCastEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
        GalleryImages: Serenity.MultipleImageUploadEditor;
        Storyline: Serenity.TextAreaEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        Runtime: Serenity.IntegerEditor;
        GenreList: Serenity.LookupEditor;
        Kind: Serenity.EnumEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = MovieCastEditor;
                var w3 = s.ImageUploadEditor;
                var w4 = s.MultipleImageUploadEditor;
                var w5 = s.IntegerEditor;
                var w6 = s.DateEditor;
                var w7 = s.LookupEditor;
                var w8 = s.EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'CastList', w2,
                    'PrimaryImage', w3,
                    'GalleryImages', w4,
                    'Storyline', w1,
                    'Year', w5,
                    'ReleaseDate', w6,
                    'Runtime', w5,
                    'GenreList', w7,
                    'Kind', w8
                ]);
            }
        }
    }
}
