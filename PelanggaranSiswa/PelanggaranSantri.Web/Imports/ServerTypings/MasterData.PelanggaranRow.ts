namespace PelanggaranSantri.MasterData {
    export interface PelanggaranRow {
        Id?: number;
        Pelanggaran?: string;
        TglPelanggaran?: string;
        Keterangan?: string;
        IdSiswa?: number;
    }

    export namespace PelanggaranRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Pelanggaran';
        export const localTextPrefix = 'MasterData.Pelanggaran';
        export const deletePermission = 'MasterData:Modify';
        export const insertPermission = 'MasterData:Modify';
        export const readPermission = 'MasterData:View';
        export const updatePermission = 'MasterData:Modify';

        export declare const enum Fields {
            Id = "Id",
            Pelanggaran = "Pelanggaran",
            TglPelanggaran = "TglPelanggaran",
            Keterangan = "Keterangan",
            IdSiswa = "IdSiswa"
        }
    }
}
