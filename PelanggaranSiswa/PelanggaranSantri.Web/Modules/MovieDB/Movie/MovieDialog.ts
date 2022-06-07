
namespace PelanggaranSantri.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieDialog extends Serenity.EntityDialog<MovieRow, any> {
        protected getFormKey() { return MovieForm.formKey; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getNameProperty() { return MovieRow.nameProperty; }
        protected getService() { return MovieService.baseUrl; }
        protected getDeletePermission() { return MovieRow.deletePermission; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getUpdatePermission() { return MovieRow.updatePermission; }

        protected form = new MovieForm(this.idPrefix);

    }
}