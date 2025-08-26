using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Souqna.Migrations
{
    /// <inheritdoc />
    public partial class ChangeProductImagesToJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductImages",
                table: "Products",
                newName: "ProductImagesJson");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductImagesJson",
                table: "Products",
                newName: "ProductImages");
        }
    }
}
