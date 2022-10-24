using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTest.Migrations.RestaurantDb
{
    public partial class SeedRestaurantsAndOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[] { 1, "We make poison, I mean Pizza!", "Pizza Slut" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderNumber", "RestaurantId" },
                values: new object[] { 1, "ON-1234", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
