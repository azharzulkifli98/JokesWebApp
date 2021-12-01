using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesWebAppMVC.Data.Migrations
{
    public partial class userID_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Joke",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Joke");
        }
    }
}
