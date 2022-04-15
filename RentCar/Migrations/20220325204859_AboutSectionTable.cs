using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Migrations
{
    public partial class AboutSectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForMoreDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    News = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSections", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutSections");
        }
    }
}
