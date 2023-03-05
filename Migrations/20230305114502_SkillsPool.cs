using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_rpg.Migrations
{
    /// <inheritdoc />
    public partial class SkillsPool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Damage",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { new Guid("5a6ba188-ef6a-4371-ac6f-07bd28cddb0e"), 20, "Super Serious Punch" },
                    { new Guid("7304111b-e77e-4371-8235-ce851b54a057"), 10, "Force Lightning" },
                    { new Guid("db470773-728e-4b9b-bcd6-5f8ec599848a"), 5, "Devastating Rhyme" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5a6ba188-ef6a-4371-ac6f-07bd28cddb0e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7304111b-e77e-4371-8235-ce851b54a057"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("db470773-728e-4b9b-bcd6-5f8ec599848a"));

            migrationBuilder.DropColumn(
                name: "Damage",
                table: "Skills");
        }
    }
}
