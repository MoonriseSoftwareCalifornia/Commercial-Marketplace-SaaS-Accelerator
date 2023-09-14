using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.SaaS.Accelerator.DataAccess.Migrations
{
    public partial class AddCosmosInstallEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CosmosInstall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true),
                    IsCosmosSite = table.Column<bool>(type: "bit", nullable: false),
                    CosmosSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherAppPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditorAppPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CosmosAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontDoorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherDnsNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditorDnsNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnsNamesHostedByCWS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignalRName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmosInstall", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CosmosInstall_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CosmosInstall_SubscriptionId",
                table: "CosmosInstall",
                column: "SubscriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CosmosInstall");
        }
    }
}
