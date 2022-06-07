
namespace PelanggaranSantri.MasterData {

    @Serenity.Decorators.registerClass()
    export class PelanggaranDialog extends Serenity.EntityDialog<PelanggaranRow, any> {
        protected getFormKey() { return PelanggaranForm.formKey; }
        protected getIdProperty() { return PelanggaranRow.idProperty; }
        protected getLocalTextPrefix() { return PelanggaranRow.localTextPrefix; }
        protected getNameProperty() { return PelanggaranRow.nameProperty; }
        protected getService() { return PelanggaranService.baseUrl; }
        protected getDeletePermission() { return PelanggaranRow.deletePermission; }
        protected getInsertPermission() { return PelanggaranRow.insertPermission; }
        protected getUpdatePermission() { return PelanggaranRow.updatePermission; }

        protected form = new PelanggaranForm(this.idPrefix);

    }
}