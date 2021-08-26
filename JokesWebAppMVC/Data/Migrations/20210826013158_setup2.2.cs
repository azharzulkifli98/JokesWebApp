using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesWebAppMVC.Data.Migrations
{
    public partial class setup22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JokeQuestion",
                table: "Joke",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JokeAnswer",
                table: "Joke",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JokeQuestion",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "JokeAnswer",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);
        }
    }
}
