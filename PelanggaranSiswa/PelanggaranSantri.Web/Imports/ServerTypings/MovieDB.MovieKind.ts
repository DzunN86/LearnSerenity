namespace PelanggaranSantri.MovieDB {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'PelanggaranSantri.MovieDB.MovieKind', 'MovieDB.MovieKind');
}
