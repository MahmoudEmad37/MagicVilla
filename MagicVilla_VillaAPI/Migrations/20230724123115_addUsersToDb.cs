using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 31, 14, 996, DateTimeKind.Local).AddTicks(596), "https://dotnetmastery.com/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 31, 14, 996, DateTimeKind.Local).AddTicks(729), "https://dotnetmastery.com/bluevillaimages/villa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 31, 14, 996, DateTimeKind.Local).AddTicks(743), "https://dotnetmastery.com/bluevillaimages/villa4.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 31, 14, 996, DateTimeKind.Local).AddTicks(758), "https://dotnetmastery.com/bluevillaimages/villa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 31, 14, 996, DateTimeKind.Local).AddTicks(773), "https://dotnetmastery.com/bluevillaimages/villa2.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 17, 18, 45, 18, 533, DateTimeKind.Local).AddTicks(512), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 17, 18, 45, 18, 533, DateTimeKind.Local).AddTicks(571), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 17, 18, 45, 18, 533, DateTimeKind.Local).AddTicks(575), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 17, 18, 45, 18, 533, DateTimeKind.Local).AddTicks(579), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdDate", "imageUrl" },
                values: new object[] { new DateTime(2023, 7, 17, 18, 45, 18, 533, DateTimeKind.Local).AddTicks(582), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg" });
        }
    }
}
