namespace PelanggaranSantri.MasterData {
    export interface SiswaRow {
        Id?: number;
        Nis?: number;
        Nama?: string;
        KotaAsal?: string;
        TglLahir?: string;
        Umur?: number;
        DetailPelanggaran?: PelanggaranRow[];
    }

    export namespace SiswaRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nama';
        export const localTextPrefix = 'MasterData.Siswa';
        export const deletePermission = 'MasterData:Modify';
        export const insertPermission = 'MasterData:Modify';
        export const readPermission = 'MasterData:View';
        export const updatePermission = 'MasterData:Modify';

        export declare const enum Fields {
            Id = "Id",
            Nis = "Nis",
            Nama = "Nama",
            KotaAsal = "KotaAsal",
            TglLahir = "TglLahir",
            Umur = "Umur",
            DetailPelanggaran = "DetailPelanggaran"
        }
    }
}
