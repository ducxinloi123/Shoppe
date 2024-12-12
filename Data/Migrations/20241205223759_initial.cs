using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shoppee.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Products",
                type: "decimal(8,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductDiscount",
                table: "Products",
                type: "decimal(2,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Products",
                type: "decimal(8,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductDiscount",
                table: "Products",
                type: "decimal(2,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldNullable: true);
        }
    }
}
