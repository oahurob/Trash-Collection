using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollection.Data.Migrations
{
    public partial class AddingIsPickedUpToServiceInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ffb97c-12cc-46af-900f-e14c2abadd25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f24e65b-a5b9-423c-bfe2-2ef9ecaec094");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eff0477c-d4cc-4ddd-b39c-19b4d36811d2");

            migrationBuilder.AddColumn<bool>(
                name: "IsPickedUp",
                table: "ServiceInfos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPickedUp",
                table: "ServiceInfos");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81ffb97c-12cc-46af-900f-e14c2abadd25", "99cab80a-eb86-49d4-b4ec-4cec0b61591f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f24e65b-a5b9-423c-bfe2-2ef9ecaec094", "b84bcd0e-3640-41a7-8874-d42eda1c40a7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eff0477c-d4cc-4ddd-b39c-19b4d36811d2", "2d8027cf-69fc-4b8d-b4d4-9bdae2197338", "Employee", "EMPLOYEE" });
        }
    }
}
