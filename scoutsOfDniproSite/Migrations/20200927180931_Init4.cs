using Microsoft.EntityFrameworkCore.Migrations;

namespace scoutsOfDniproSite.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastEvent",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastSignIn",
                table: "users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastEvent",
                table: "users");

            migrationBuilder.DropColumn(
                name: "LastSignIn",
                table: "users");
        }
    }
}
