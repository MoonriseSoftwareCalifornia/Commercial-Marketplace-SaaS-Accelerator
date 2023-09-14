using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.SaaS.Accelerator.DataAccess.Migrations
{
    public partial class AddUserQuestionaireInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowLocalLogins",
                table: "CosmosInstall",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CWSAzureB2CProviderList",
                table: "CosmosInstall",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastUpdatedByCustomer",
                table: "CosmosInstall",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "UseCWSEntraID",
                table: "CosmosInstall",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UseCustomerEntraID",
                table: "CosmosInstall",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowLocalLogins",
                table: "CosmosInstall");

            migrationBuilder.DropColumn(
                name: "CWSAzureB2CProviderList",
                table: "CosmosInstall");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByCustomer",
                table: "CosmosInstall");

            migrationBuilder.DropColumn(
                name: "UseCWSEntraID",
                table: "CosmosInstall");

            migrationBuilder.DropColumn(
                name: "UseCustomerEntraID",
                table: "CosmosInstall");
        }
    }
}
