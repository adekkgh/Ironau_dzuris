using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ironau_Dzuris.Db.Migrations.ModBuild
{
    public partial class AddPhrasesModBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phrases",
                columns: new[] { "Id", "Phrase_os", "Phrase_ru", "Theme" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Дæ ном куыд у?", "Как тебя зовут?", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Дæ(Уæ) рáйсом хорз", "Доброе утро", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Дæ и́зæр хорз", "Добрый вечер", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Дæ бон хорз", "Добрый день", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Хæрхǽхсæв", "Спокойной ночи", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "О", "Да", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Нæ", "Нет", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Хорз", "Хорошо", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Бузныг", "Спасибо", "Без темы" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Стыр Бузныг", "Большое спасибо", "Без темы" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Phrases",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));
        }
    }
}
