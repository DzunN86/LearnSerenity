
namespace PelanggaranSantri.MasterData {

    @Serenity.Decorators.registerClass()
    export class PelanggaranDetailEditorDialog extends Serenity.Extensions.GridEditorDialog<PelanggaranRow> {
        protected getFormKey() { return PelanggaranForm.formKey; }
        protected getLocalTextPrefix() { return PelanggaranRow.localTextPrefix; }

        protected form: PelanggaranForm;

        constructor() {
            super();
            this.form = new PelanggaranForm(this.idPrefix);
        }
    }
}