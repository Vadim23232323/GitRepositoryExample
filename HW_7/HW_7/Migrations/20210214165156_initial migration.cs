using Microsoft.EntityFrameworkCore.Migrations;

namespace HW_7.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarName", "Color", "ModelName", "Year" },
                values: new object[] { 1, "Audi", "green", "80", 35 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarName", "Color", "ModelName", "Year" },
                values: new object[] { 2, "Opel", "blue", "astra", 35 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarName", "Color", "ModelName", "Year" },
                values: new object[] { 3, "Audi", "green", "80", 35 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
