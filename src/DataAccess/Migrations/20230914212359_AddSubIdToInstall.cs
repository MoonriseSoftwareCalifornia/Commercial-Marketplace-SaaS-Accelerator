using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.SaaS.Accelerator.DataAccess.Migrations
{
    public partial class AddSubIdToInstall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmosInstalls_Subscriptions_SubscriptionsId",
                table: "CosmosInstalls");

            migrationBuilder.DropIndex(
                name: "IX_CosmosInstalls_SubscriptionsId",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "SubscriptionsId",
                table: "CosmosInstalls");

            migrationBuilder.AlterColumn<bool>(
                name: "UseCWSEntraID",
                table: "CosmosInstalls",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionId",
                table: "CosmosInstalls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CosmosInstalls_SubscriptionId",
                table: "CosmosInstalls",
                column: "SubscriptionId");

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

            migrationBuilder.DropIndex(
                name: "IX_CosmosInstalls_SubscriptionId",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "CosmosInstalls");

            migrationBuilder.AlterColumn<bool>(
                name: "UseCWSEntraID",
                table: "CosmosInstalls",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionsId",
                table: "CosmosInstalls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CosmosInstalls_SubscriptionsId",
                table: "CosmosInstalls",
                column: "SubscriptionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CosmosInstalls_Subscriptions_SubscriptionsId",
                table: "CosmosInstalls",
                column: "SubscriptionsId",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }
    }
}
