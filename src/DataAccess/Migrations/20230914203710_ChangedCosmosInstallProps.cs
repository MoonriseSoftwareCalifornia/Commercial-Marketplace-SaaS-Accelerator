using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.SaaS.Accelerator.DataAccess.Migrations
{
    public partial class ChangedCosmosInstallProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmosInstalls_Subscriptions_SubscriptionId",
                table: "CosmosInstalls");

            migrationBuilder.DropIndex(
                name: "IX_CosmosInstalls_SubscriptionId",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "DnsNamesHostedByCWS",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "CosmosInstalls");

            migrationBuilder.RenameColumn(
                name: "CosmosSubscriptionId",
                table: "CosmosInstalls",
                newName: "AmpsubscriptionId");

            migrationBuilder.AddColumn<bool>(
                name: "DomainHostedByCosmos",
                table: "CosmosInstalls",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmosInstalls_Subscriptions_SubscriptionsId",
                table: "CosmosInstalls");

            migrationBuilder.DropIndex(
                name: "IX_CosmosInstalls_SubscriptionsId",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "DomainHostedByCosmos",
                table: "CosmosInstalls");

            migrationBuilder.DropColumn(
                name: "SubscriptionsId",
                table: "CosmosInstalls");

            migrationBuilder.RenameColumn(
                name: "AmpsubscriptionId",
                table: "CosmosInstalls",
                newName: "CosmosSubscriptionId");

            migrationBuilder.AddColumn<string>(
                name: "DnsNamesHostedByCWS",
                table: "CosmosInstalls",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
