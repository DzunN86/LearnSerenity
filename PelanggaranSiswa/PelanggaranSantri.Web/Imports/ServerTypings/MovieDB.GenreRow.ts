namespace PelanggaranSantri.MovieDB {
    export interface GenreRow {
        GenreId?: number;
        Name?: string;
    }

    export namespace GenreRow {
        export const idProperty = 'GenreId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MovieDB.Genre';
        export const lookupKey = 'MovieDB.Genre';

        export function getLookup(): Q.Lookup<GenreRow> {
            return Q.getLookup<GenreRow>('MovieDB.Genre');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            GenreId = "GenreId",
            Name = "Name"
        }
    }
}
