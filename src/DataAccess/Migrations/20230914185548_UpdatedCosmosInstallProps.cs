using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.SaaS.Accelerator.DataAccess.Migrations
{
    public partial class UpdatedCosmosInstallProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmosInstall_Subscriptions_SubscriptionId",
                table: "CosmosInstall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CosmosInstall",
                table: "CosmosInstall");

            migrationBuilder.RenameTable(
                name: "CosmosInstall",
                newName: "CosmosInstalls");

            migrationBuilder.RenameIndex(
                name: "IX_CosmosInstall_SubscriptionId",
                table: "CosmosInstalls",
                newName: "IX_CosmosInstalls_SubscriptionId");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionId",
                table: "CosmosInstalls",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "CosmosInstalls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateTimeProvisioned",
                table: "CosmosInstalls",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "InternalNotes",
                table: "CosmosInstalls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MalwareScan",
                table: "CosmosInstalls",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CosmosInstalls",
                table: "CosmosInstalls",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CosmosInstalls_Subscriptions_SubscriptionId",
                table: "CosmosInstalls",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmosInstalls_Subscriptions_SubscriptionId",
                table: "CosmosInstalls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CosmosInstalls",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "DateTimeProvisioned",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "InternalNotes",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "MalwareScan",
                table: "CosmosInstalls");

            migrationBuilder.RenameTable(
                name: "CosmosInstalls",
                newName: "CosmosInstall");

            migrationBuilder.RenameIndex(
                name: "IX_CosmosInstalls_SubscriptionId",
                table: "CosmosInstall",
                newName: "IX_CosmosInstall_SubscriptionId");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionId",
                table: "CosmosInstall",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CosmosInstall",
                table: "CosmosInstall",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CosmosInstall_Subscriptions_SubscriptionId",
                table: "CosmosInstall",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }
    }
}
