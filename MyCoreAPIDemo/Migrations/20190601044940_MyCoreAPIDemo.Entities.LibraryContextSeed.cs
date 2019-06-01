using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCoreAPIDemo.Migrations
{
    public partial class MyCoreAPIDemoEntitiesLibraryContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("312f68a4-a401-45b1-883e-51932bee5b19"), "Bob", "Drama", "Ross" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("08b36a1d-f2ec-4ba4-b1f2-65391e5ec709"), "David", "Fantasy", "Miller" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("08b36a1d-f2ec-4ba4-b1f2-65391e5ec709"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("312f68a4-a401-45b1-883e-51932bee5b19"));
        }
    }
}
