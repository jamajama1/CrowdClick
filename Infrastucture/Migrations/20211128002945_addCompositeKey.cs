using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastucture.Migrations
{
    public partial class addCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Product_ProductId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProductId",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Project",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ProductPrice",
                table: "Project",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductVendorId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                columns: new[] { "Name", "VendorId", "Price" });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProductName_ProductVendorId_ProductPrice",
                table: "Project",
                columns: new[] { "ProductName", "ProductVendorId", "ProductPrice" });

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Product_ProductName_ProductVendorId_ProductPrice",
                table: "Project",
                columns: new[] { "ProductName", "ProductVendorId", "ProductPrice" },
                principalTable: "Product",
                principalColumns: new[] { "Name", "VendorId", "Price" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Product_ProductName_ProductVendorId_ProductPrice",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProductName_ProductVendorId_ProductPrice",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProductVendorId",
                table: "Project");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProductId",
                table: "Project",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Product_ProductId",
                table: "Project",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
