using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumberToDbCaptial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_villaNumbers",
                table: "villaNumbers");

            migrationBuilder.RenameTable(
                name: "villaNumbers",
                newName: "VillaNumbers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VillaNumbers",
                table: "VillaNumbers",
                column: "VillaNo");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 57, 53, 774, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 57, 53, 774, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 57, 53, 774, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 57, 53, 774, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 57, 53, 774, DateTimeKind.Local).AddTicks(448));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VillaNumbers",
                table: "VillaNumbers");

            migrationBuilder.RenameTable(
                name: "VillaNumbers",
                newName: "villaNumbers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_villaNumbers",
                table: "villaNumbers",
                column: "VillaNo");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 50, 1, 621, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 50, 1, 621, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 50, 1, 621, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 50, 1, 621, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 21, 50, 1, 621, DateTimeKind.Local).AddTicks(9104));
        }
    }
}
