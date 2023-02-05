using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace toletwebapp.Migrations
{
    public partial class singleimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "Image5",
                table: "Flats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Flats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Flats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Flats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image5",
                table: "Flats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
