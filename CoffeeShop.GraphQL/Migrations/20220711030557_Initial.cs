using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShop.GraphQL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beverages",
                columns: table => new
                {
                    BeverageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BeverageName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    BasePrice = table.Column<double>(type: "REAL", nullable: false),
                    SalesPrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beverages", x => x.BeverageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beverages");
        }
    }
}
