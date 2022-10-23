using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTest.Migrations
{
    public partial class SeedDbUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 0, "Andrew", "Babcock" },
                    { 2, 0, "Dave", "McDonald" },
                    { 3, 0, "Chris", "Smith" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
