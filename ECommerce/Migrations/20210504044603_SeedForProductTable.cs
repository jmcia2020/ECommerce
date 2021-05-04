using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class SeedForProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Category_Id", "Description", "Name", "OnSale", "Price", "ProdImageUrl" },
                values: new object[] { 2, null, null, "Burlap 18 X 18 pillow cover with Summer Flowers motif", "Summer Pillow Cover", true, 15.75m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Category_Id", "Description", "Name", "OnSale", "Price", "ProdImageUrl" },
                values: new object[] { 3, null, null, "Yellow 100% Cotton 50\" x 60\" throw blanket", "Throw Blanket", false, 19.75m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Category_Id", "Description", "Name", "OnSale", "Price", "ProdImageUrl" },
                values: new object[] { 4, null, null, "Standard size machine washable medium firm down alternative pillow", "Down Alternative Bed Pillow", false, 25.43m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
