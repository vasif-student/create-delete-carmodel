using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Migrations
{
    public partial class AddOwnerIdRowToCarModelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "CarModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "CarModels");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
