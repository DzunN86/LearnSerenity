
namespace PelanggaranSantri.MasterData {

    @Serenity.Decorators.registerClass()
    export class SiswaDialog extends Serenity.EntityDialog<SiswaRow, any> {
        protected getFormKey() { return SiswaForm.formKey; }
        protected getIdProperty() { return SiswaRow.idProperty; }
        protected getLocalTextPrefix() { return SiswaRow.localTextPrefix; }
        protected getNameProperty() { return SiswaRow.nameProperty; }
        protected getService() { return SiswaService.baseUrl; }
        protected getDeletePermission() { return SiswaRow.deletePermission; }
        protected getInsertPermission() { return SiswaRow.insertPermission; }
        protected getUpdatePermission() { return SiswaRow.updatePermission; }

        protected form = new SiswaForm(this.idPrefix);

    }
}