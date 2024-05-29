﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Look_For_It.Db.Migrations.Phrase
{
    public partial class FixPhraseFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Them",
                table: "Phrases",
                newName: "Theme");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Theme",
                table: "Phrases",
                newName: "Them");
        }
    }
}
