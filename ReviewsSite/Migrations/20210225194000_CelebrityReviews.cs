using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class CelebrityReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewContent",
                value: "If it isn't Doge coin... At least it's shaped like a coin. #SpaceX");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewContent",
                value: "Ruh Ro Raggy! Resse Aren't Scooby Snacks!!!");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ReviewContent", "ReviewScore", "ReviewerName", "ToppingsId" },
                values: new object[,]
                {
                    { 3, "The only thing better than this topping is the review(Site)", 5, "Carlos", 1 },
                    { 4, "Pika Pika, Pikachu!", 1, "Pikachu", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewContent",
                value: "Content Area");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewContent",
                value: "Area of Content");
        }
    }
}
