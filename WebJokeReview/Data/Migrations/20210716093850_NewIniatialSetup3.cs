using Microsoft.EntityFrameworkCore.Migrations;

namespace WebJokeReview.Data.Migrations
{
    public partial class NewIniatialSetup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "Joke",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userName",
                table: "Joke");
        }
    }
}
