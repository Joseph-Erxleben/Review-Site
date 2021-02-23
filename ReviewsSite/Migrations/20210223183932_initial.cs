using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Description", "IsVegetarian", "Name", "Review" },
                values: new object[] { 1, "Delicious", false, "Pepperoni", "Review" });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Description", "IsVegetarian", "Name", "Review" },
                values: new object[] { 2, "Delicious", true, "Green Pepper", "Review" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toppings");
        }
    }
}
