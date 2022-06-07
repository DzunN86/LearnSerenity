
namespace PelanggaranSantri.MasterData {

    @Serenity.Decorators.registerClass()
    export class PelanggaranGrid extends Serenity.EntityGrid<PelanggaranRow, any> {
        protected getColumnsKey() { return PelanggaranColumns.columnsKey; }
        protected getDialogType() { return PelanggaranDialog; }
        protected getIdProperty() { return PelanggaranRow.idProperty; }
        protected getInsertPermission() { return PelanggaranRow.insertPermission; }
        protected getLocalTextPrefix() { return PelanggaranRow.localTextPrefix; }
        protected getService() { return PelanggaranService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}