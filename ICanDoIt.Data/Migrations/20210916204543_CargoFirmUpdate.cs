using Microsoft.EntityFrameworkCore.Migrations;

namespace ICanDoIt.Data.Migrations
{
    public partial class CargoFirmUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cargoFirm",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "trackingCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cargoFirm",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "trackingCode",
                table: "Orders");
        }
    }
}
