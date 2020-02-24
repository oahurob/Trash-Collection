using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollection.Data.Migrations
{
    public partial class addEmployeeAndCustomerToRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0ef34a0-2e89-4efe-bc5e-cf40f88aa53d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "519e9667-b757-4c16-a640-5747ce31bfb0", "187b4adc-57c9-4774-b559-bbbb87f5032c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "192eaf7f-8114-4a49-be4a-87444b2481ff", "17693ed9-494e-45d2-bfde-1c531b309b06", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09b4a823-b045-4998-a832-8b919f22e414", "127a6d1d-ee8c-42ba-a92f-45e0a36dc4e7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b4a823-b045-4998-a832-8b919f22e414");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "192eaf7f-8114-4a49-be4a-87444b2481ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519e9667-b757-4c16-a640-5747ce31bfb0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0ef34a0-2e89-4efe-bc5e-cf40f88aa53d", "750cc515-5558-4ff3-84d0-b46b6931d6f3", "Admin", "ADMIN" });
        }
    }
}
