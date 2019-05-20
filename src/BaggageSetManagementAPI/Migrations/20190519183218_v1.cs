using Microsoft.EntityFrameworkCore.Migrations;

namespace Pitstop.Application.BaggageSetManagement.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaggageSet",
                columns: table => new
                {
                    ScheduledFlightId = table.Column<string>(nullable: false),
                    BaggageClaimId = table.Column<string>(nullable: true),
                    LoadedOnFlight = table.Column<bool>(nullable: false),
                    DeliveredToBaggageClaim = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaggageSet", x => x.ScheduledFlightId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaggageSet");
        }
    }
}
