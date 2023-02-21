using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace toletwebapp.Migrations
{
    public partial class searchMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchFilters",
                columns: table => new
                {
                    SearchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinRange = table.Column<double>(type: "float", nullable: false),
                    MaxRange = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchFilters", x => x.SearchId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchFilters");
        }
    }
}
