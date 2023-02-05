using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace toletwebapp.Migrations
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flats_Buildings_BuildingId",
                table: "Flats");

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingId",
                table: "Flats",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Flats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_Buildings_BuildingId",
                table: "Flats",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flats_Buildings_BuildingId",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Flats");

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingId",
                table: "Flats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_Buildings_BuildingId",
                table: "Flats",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
