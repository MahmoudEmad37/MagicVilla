using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 7, 12, 0, 7, 57, 981, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 7, 12, 0, 7, 57, 981, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 7, 12, 0, 7, 57, 981, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 7, 12, 0, 7, 57, 981, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 7, 12, 0, 7, 57, 981, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 23, 17, 9, 829, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 23, 17, 9, 829, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 23, 17, 9, 829, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 23, 17, 9, 829, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 23, 17, 9, 829, DateTimeKind.Local).AddTicks(4027));
        }
    }
}
