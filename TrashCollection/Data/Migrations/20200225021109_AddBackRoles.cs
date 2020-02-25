using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollection.Data.Migrations
{
    public partial class AddBackRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af97afa7-eaaa-4a5e-b714-d7a50521788a", "b96ddccb-36c3-47b8-9040-e7a290de7b06", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b11044f-8d88-40a8-b245-24b0f9a2bfdf", "1655fdb7-33e5-4405-8eec-1e6e7d7198b7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c60862e-3e6b-4be9-a6e0-088a9f25864e", "dfbc3c0b-4d9c-419c-895f-71380ec4bfc2", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b11044f-8d88-40a8-b245-24b0f9a2bfdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c60862e-3e6b-4be9-a6e0-088a9f25864e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af97afa7-eaaa-4a5e-b714-d7a50521788a");
        }
    }
}
