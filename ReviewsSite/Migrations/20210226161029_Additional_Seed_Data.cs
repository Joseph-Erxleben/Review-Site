using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Additional_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewerName",
                value: "Carlos Lopez");

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Description", "Img", "IsVegetarian", "Name" },
                values: new object[,]
                {
                    { 3, "Coarsely ground pork (and sometimes beef) with fennel, also known as “mild” Italian sausage.", "Sausage.png", false, "Sausage" },
                    { 4, "A large juicy tropical fruit consisting of aromatic edible yellow flesh surrounded by a tough segmented skin and topped with a tuft of stiff leaves.", "Pineapple.png", true, "Pineapple" },
                    { 5, "Bacon is a type of salt-cured pork made from various cuts, typically from the pork belly or from the less fatty back cuts.", "Bacon.png", false, "Bacon" },
                    { 6, "An enlarged complex aboveground fleshy fruiting body of a fungus (such as a basidiomycete) that consists typically of a stem bearing a pileus.", "Mushroom.png", true, "Mushrooms" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ReviewContent", "ReviewScore", "ReviewerName", "ToppingsId" },
                values: new object[,]
                {
                    { 5, "I like my sausage bulky, like me.", 5, "Dwayne 'The Rock' Johnson", 3 },
                    { 6, "Better than pepperoni.", 4, "Davis Murphy", 3 },
                    { 7, "I love pineapple so much that I live in one.", 5, "SpongeBob SquarePants", 4 },
                    { 8, "I hate pineapples because my neighbor lives in one.", 0, "Squidward Tentacles", 4 },
                    { 9, "It sucks.  It's Great!", 3, "CatDog", 5 },
                    { 10, "I always need more.", 4, "Clifford The Big Red Dog", 5 },
                    { 11, "MUSHROOMS!", 5, "Peregrin 'Pippin' Took", 6 },
                    { 12, "Zoinks Scoob! Like, sign me up for more man.", 5, "Shaggy", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewerName",
                value: "Carlos");
        }
    }
}
