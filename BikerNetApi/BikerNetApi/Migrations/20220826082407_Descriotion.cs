using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikerNetApi.Migrations
{
    public partial class Descriotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FeedPosts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "FeedPosts");
        }
    }
}
