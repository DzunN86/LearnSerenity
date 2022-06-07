
namespace PelanggaranSantri.MovieDB {

    import fld = MovieRow.Fields;

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return MovieColumns.columnsKey; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            const txt = (s) => 
                Q.text(`Db.${MovieRow.localTextPrefix}.${s}`).toLowerCase();

            return [
                { name: "", title: "all" },
                { name: fld.Description, title: txt(fld.Description) },
                { name: fld.Storyline, title: txt(fld.Storyline) },
                { name: fld.Year, title: txt(fld.Year) }
            ];
        }

        protected getQuickFilters() {
            let items = super.getQuickFilters();
    
            const genreListFilter = Q.first(items, x =>
                x.field == MovieRow.Fields.GenreList);
    
            genreListFilter.handler = h => {
                const request = (h.request as MovieListRequest);
                const values = (h.widget as Serenity.LookupEditor).values;
                request.Genres = values.map(x => parseInt(x, 10));
                h.handled = true;
            };
    
            return items;
        }

    }
}