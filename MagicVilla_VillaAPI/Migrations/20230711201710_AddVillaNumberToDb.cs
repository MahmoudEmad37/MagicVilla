using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    villaNo = table.Column<int>(type: "int", nullable: false),
                    specialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.villaNo);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 0, 13, 58, 791, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 0, 13, 58, 791, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 3,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 0, 13, 58, 791, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 4,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 0, 13, 58, 791, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 5,
                column: "createdDate",
                value: new DateTime(2023, 7, 11, 0, 13, 58, 791, DateTimeKind.Local).AddTicks(8752));
        }
    }
}
