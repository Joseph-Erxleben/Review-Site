using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Reviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewScore = table.Column<int>(type: "int", nullable: false),
                    ToppingsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Toppings_ToppingsId",
                        column: x => x.ToppingsId,
                        principalTable: "Toppings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ReviewContent", "ReviewScore", "ReviewerName", "ToppingsId" },
                values: new object[] { 1, "Content Area", 0, "Elon Musk", null });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ReviewContent", "ReviewScore", "ReviewerName", "ToppingsId" },
                values: new object[] { 2, "Area of Content", 0, "Scooby Doo", null });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ToppingsId",
                table: "Reviews",
                column: "ToppingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
