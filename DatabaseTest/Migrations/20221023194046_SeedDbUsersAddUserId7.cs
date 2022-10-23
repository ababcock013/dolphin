using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTest.Migrations
{
    public partial class SeedDbUsersAddUserId7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 7, 73, "John", "Williams" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
