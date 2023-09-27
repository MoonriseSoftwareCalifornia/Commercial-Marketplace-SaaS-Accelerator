using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.SaaS.Accelerator.DataAccess.Migrations
{
    public partial class AddEditorAndPublisherAndLayoutPreload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EditorUrl",
                table: "CosmosInstalls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreloadLayout",
                table: "CosmosInstalls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublisherUrl",
                table: "CosmosInstalls",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditorUrl",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "PreloadLayout",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "PublisherUrl",
                table: "CosmosInstalls");
        }
    }
}
