using FluentMigrator;

namespace PelanggaranSantri.Migrations.DefaultDB
{
    [Migration(20160603_205900)]
    public class DefaultDB_20160603_205900_PersonMovieImages : Migration
    {
        public override void Up()
        {
            Alter.Table("Person")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

            Alter.Table("Movie")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
        }

        public override void Down()
        {
        }
    }
}