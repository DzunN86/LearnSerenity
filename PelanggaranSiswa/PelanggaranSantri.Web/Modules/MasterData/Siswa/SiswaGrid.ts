
namespace PelanggaranSantri.MasterData {

    @Serenity.Decorators.registerClass()
    export class SiswaGrid extends Serenity.EntityGrid<SiswaRow, any> {
        protected getColumnsKey() { return SiswaColumns.columnsKey; }
        protected getDialogType() { return SiswaDialog; }
        protected getIdProperty() { return SiswaRow.idProperty; }
        protected getInsertPermission() { return SiswaRow.insertPermission; }
        protected getLocalTextPrefix() { return SiswaRow.localTextPrefix; }
        protected getService() { return SiswaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {

            var buttons = super.getButtons();

            buttons.push(Serenity.Extensions.ExcelExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                service: SiswaService.baseUrl + '/ListExcel',
                separator: true
            }));

            buttons.push(Serenity.Extensions.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));

            return buttons;
        }
    }
}