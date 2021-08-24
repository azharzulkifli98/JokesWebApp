using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesWebAppMVC.Data.Migrations
{
    public partial class setup20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Joke",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Date",
                table: "Joke",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Joke",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Joke");
        }
    }
}
