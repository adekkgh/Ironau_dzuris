using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ironau_Dzuris.Db.Migrations.Words
{
    public partial class InitWordsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Word_ru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Word_os = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Phrase_os", "Theme" },
                values: new object[] { "Хæрзǽхсæв", "Общение" });

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Theme",
                value: "Общение");

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "ImagePath", "Theme", "Word_os", "Word_ru" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000019"), "~/images/words/Дверь.png", "", "Дуар", "Дверь" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "~/images/words/Индюк.jpg", "", "Гогыз", "Индюк" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "~/images/words/Огурец.jpg", "", "Джитъри", "Огурец" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "~/images/words/Рыба.jpg", "", "Кæсаг", "Рыба" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "~/images/words/Вишня.jpg", "", "Бал", "Вишня" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "~/images/words/Лопата.jpg", "", "Бел", "Лопата" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "~/images/words/Девочка.jpg", "", "Чызг", "Девочка" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "~/images/words/Луна.jpg", "", "Мæй", "Луна" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "~/images/words/Солнце.jpg", "", "Хур", "Солнце" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "~/images/words/Мяч.jpg", "", "Пурти", "Мяч" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "~/images/words/Яблоко.jpg", "", "Фæткъуы", "Яблоко" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "~/images/words/Книга.jpg", "", "Чиныг", "Книга" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "~/images/words/Стол.jpg", "", "Фынг", "Стол" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "~/images/words/Собака.jpg", "", "Куыдз", "Собака" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "~/images/words/Кот.jpg", "", "Гæды", "Кот" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "~/images/words/Дом.jpg", "", "Хæдзар", "Дом" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "~/images/words/Мальчик.jpg", "", "Лæппу", "Мальчик" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "~/images/words/Вода.jpg", "", "Дон", "Вода" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "~/images/words/Дерево.jpg", "", "Бæлас", "Дерево" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Phrase_os", "Theme" },
                values: new object[] { "Хæрхǽхсæв", "Без темы" });

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Theme",
                value: "Без темы");

            migrationBuilder.UpdateData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Theme",
                value: "Без темы");
        }
    }
}
