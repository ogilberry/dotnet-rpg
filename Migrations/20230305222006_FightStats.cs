using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_rpg.Migrations
{
    /// <inheritdoc />
    public partial class FightStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { new Guid("7a11e32c-7562-4527-a50d-5ab2e31a0b3b"), 5, "Devastating Rhyme" },
                    { new Guid("b8ecb61b-75da-4fe4-a969-e8259721f9ea"), 20, "Super Serious Punch" },
                    { new Guid("ef195dcd-fbff-409d-9945-d864e618a4e4"), 10, "Force Lightning" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7a11e32c-7562-4527-a50d-5ab2e31a0b3b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b8ecb61b-75da-4fe4-a969-e8259721f9ea"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ef195dcd-fbff-409d-9945-d864e618a4e4"));

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
    }
}
