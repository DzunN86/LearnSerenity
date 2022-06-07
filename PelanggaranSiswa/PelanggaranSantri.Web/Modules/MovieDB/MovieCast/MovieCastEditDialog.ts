namespace PelanggaranSantri.MovieDB {

  @Serenity.Decorators.registerClass()
  export class MovieCastEditDialog extends
      Serenity.Extensions.GridEditorDialog<MovieCastRow> {
      protected getFormKey() { return MovieCastForm.formKey; }
      protected getNameProperty() { return MovieCastRow.nameProperty; }
      protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

      protected form: MovieCastForm = new MovieCastForm(this.idPrefix);

      constructor() {
          super();
      }
  }
}