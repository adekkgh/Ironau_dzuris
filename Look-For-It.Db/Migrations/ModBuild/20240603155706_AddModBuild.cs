using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Look_For_It.Db.Migrations.ModBuild
{
    public partial class AddModBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { new Guid("00000000-aaaa-aaaa-aaaa-000000000000"), "admin@admin.ru", "admin", "aDMiN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-aaaa-aaaa-aaaa-000000000000"));
        }
    }
}
