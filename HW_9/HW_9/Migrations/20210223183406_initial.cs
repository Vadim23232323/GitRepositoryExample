using Microsoft.EntityFrameworkCore.Migrations;

namespace HW_9.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorIdentifier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorIdentifier);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Author_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Author",
                        principalColumn: "AuthorIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorIdentifier", "Description", "FirstName", "LastName" },
                values: new object[] { 1, "My car audi", "Vadim", "Dubovskiy" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorIdentifier", "Description", "FirstName", "LastName" },
                values: new object[] { 2, "My car audi", "Vadim", "Dubovskiy" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorIdentifier", "Description", "FirstName", "LastName" },
                values: new object[] { 3, "My car audi", "Vadim", "Dubovskiy" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AuthorID", "CarName", "Color", "ModelName", "Year" },
                values: new object[] { 1, 1, "Audi", "green", "80", 35 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AuthorID", "CarName", "Color", "ModelName", "Year" },
                values: new object[] { 2, 2, "Opel", "blue", "astra", 35 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AuthorID", "CarName", "Color", "ModelName", "Year" },
                values: new object[] { 3, 3, "Audi", "green", "80", 35 });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AuthorID",
                table: "Cars",
                column: "AuthorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
