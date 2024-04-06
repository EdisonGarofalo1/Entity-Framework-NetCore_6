using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkNetCore_6.Migrations
{
    public partial class tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_Categoriacat_id",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_Categoriacat_id",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Categoriacat_id",
                table: "Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_cat_id",
                table: "Producto",
                column: "cat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria",
                table: "Producto",
                column: "cat_id",
                principalTable: "Categoria",
                principalColumn: "cat_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_cat_id",
                table: "Producto");

            migrationBuilder.AddColumn<int>(
                name: "Categoriacat_id",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Categoriacat_id",
                table: "Producto",
                column: "Categoriacat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_Categoriacat_id",
                table: "Producto",
                column: "Categoriacat_id",
                principalTable: "Categoria",
                principalColumn: "cat_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
