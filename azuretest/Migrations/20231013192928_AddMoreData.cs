using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azuretest.Migrations
{
    public partial class AddMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Address", "City", "Phone" },
                values: new object[] { "123 Main St", "New York", "1234567890" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Address", "City", "Phone" },
                values: new object[] { "123 Main St", "New York", "1234567890" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Address", "City", "Phone" },
                values: new object[] { "123 Main St", "New York", "1234567890" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Address", "City", "Phone" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Address", "City", "Phone" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Address", "City", "Phone" },
                values: new object[] { null, null, null });
        }
    }
}
