using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azuretest.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Address", "City", "Email", "Name", "Phone", "State", "Zip" },
                values: new object[] { 1, null, null, "abc@gmail.com", "John Doe", null, null, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Address", "City", "Email", "Name", "Phone", "State", "Zip" },
                values: new object[] { 2, null, null, "abc@gmail.com", "Sammy", null, null, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Address", "City", "Email", "Name", "Phone", "State", "Zip" },
                values: new object[] { 3, null, null, "abc@gmail.com", "Sammy Doe", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
