using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_rpg.Migrations
{
    /// <inheritdoc />
    public partial class FightStats2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Defeats",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fights",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Victories",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { new Guid("554869fd-0f30-47dc-be7a-4000dc2380ff"), 20, "Super Serious Punch" },
                    { new Guid("916aab37-e8c3-4182-ac6c-1cc0f820bed1"), 10, "Force Lightning" },
                    { new Guid("9f652c01-cb87-4f10-8d3e-5fe7b4f36bea"), 5, "Devastating Rhyme" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("554869fd-0f30-47dc-be7a-4000dc2380ff"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("916aab37-e8c3-4182-ac6c-1cc0f820bed1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9f652c01-cb87-4f10-8d3e-5fe7b4f36bea"));

            migrationBuilder.DropColumn(
                name: "Defeats",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Fights",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Victories",
                table: "Characters");

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
    }
}
