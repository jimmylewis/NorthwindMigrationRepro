using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindMigrationRepro.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(DbSeedData.SqlQuery);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
