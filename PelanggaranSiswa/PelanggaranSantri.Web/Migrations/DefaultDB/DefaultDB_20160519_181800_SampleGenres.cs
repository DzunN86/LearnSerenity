using FluentMigrator;

namespace PelanggaranSantri.Migrations.DefaultDB
{
    [Migration(20160519_181800)]
    public class DefaultDB_20160519_181800_SampleGenres : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Genre")
                .Row(new
                {
                    Name = "Action"
                })
                .Row(new
                {
                    Name = "Drama"
                })
                .Row(new
                {
                    Name = "Comedy"
                })
                .Row(new
                {
                    Name = "Sci-fi"
                })
                .Row(new
                {
                    Name = "Fantasy"
                })
                .Row(new
                {
                    Name = "Documentary"
                });
        }

        public override void Down()
        {
        }
    }
}