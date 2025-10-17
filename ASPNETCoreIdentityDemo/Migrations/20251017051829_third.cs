using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNETCoreIdentityDemo.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b92f0a3e-573b-4b12-8db1-2ccf6d58a34a"),
                column: "ConcurrencyStamp",
                value: "22222222-2222-2222-2222-222222222222");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8d89a25-4b96-4f20-9d79-7f8a54c5213d"),
                column: "ConcurrencyStamp",
                value: "11111111-1111-1111-1111-111111111111");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d7f4a42e-1c1b-4c9f-8a50-55f6b234e8e2"),
                column: "ConcurrencyStamp",
                value: "33333333-3333-3333-3333-333333333333");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f2e6b8a1-9d43-4a7c-9f32-71d7c5dbe9f0"),
                column: "ConcurrencyStamp",
                value: "44444444-4444-4444-4444-444444444444");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b92f0a3e-573b-4b12-8db1-2ccf6d58a34a"),
                column: "ConcurrencyStamp",
                value: "9afa55a1-9c74-482a-9c54-a33e49c4b075");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8d89a25-4b96-4f20-9d79-7f8a54c5213d"),
                column: "ConcurrencyStamp",
                value: "48fee53c-8caa-4568-83d4-1a0092d344d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d7f4a42e-1c1b-4c9f-8a50-55f6b234e8e2"),
                column: "ConcurrencyStamp",
                value: "5802e62b-060a-44fd-80ac-d2b5882106b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f2e6b8a1-9d43-4a7c-9f32-71d7c5dbe9f0"),
                column: "ConcurrencyStamp",
                value: "c6fbf7eb-c046-4c96-840d-326f9d93c4ec");
        }
    }
}
