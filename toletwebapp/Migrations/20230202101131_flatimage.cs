using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace toletwebapp.Migrations
{
    public partial class flatimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    FlatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    Beds = table.Column<int>(type: "int", nullable: false),
                    Baths = table.Column<int>(type: "int", nullable: false),
                    Balcony = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rent = table.Column<double>(type: "float", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image5 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.FlatId);
                    table.ForeignKey(
                        name: "FK_Flats_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flats_BuildingId",
                table: "Flats",
                column: "BuildingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flats");
        }
    }
}
