using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkNetCore_6.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    cat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    cat_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.cat_id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    per_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    per_identificacion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    cp_sexo = table.Column<int>(type: "int", nullable: false),
                    cp_estado_civil = table.Column<int>(type: "int", nullable: false),
                    per_nombres = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    per_telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    per_direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    per_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.per_id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Movimiento",
                columns: table => new
                {
                    tip_mov_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip_mov_descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    tip_mov_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Movimiento", x => x.tip_mov_id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usu_nombres = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_apellidos = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_usuario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_clave = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    usu_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usu_id);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    pro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    Categoriacat_id = table.Column<int>(type: "int", nullable: false),
                    pro_codigo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    pro_descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    pro_precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    pro_lleva_iva = table.Column<bool>(type: "bit", nullable: false),
                    pro_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.pro_id);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_Categoriacat_id",
                        column: x => x.Categoriacat_id,
                        principalTable: "Categoria",
                        principalColumn: "cat_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cab_Movimiento",
                columns: table => new
                {
                    cab_mov_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cab_mov_num_doc = table.Column<int>(type: "int", nullable: false),
                    tip_mov_id = table.Column<int>(type: "int", nullable: false),
                    Tipo_Movimientotip_mov_id = table.Column<int>(type: "int", nullable: false),
                    cab_movimiento = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    per_id = table.Column<int>(type: "int", nullable: false),
                    Personaper_id = table.Column<int>(type: "int", nullable: false),
                    cab_mov_fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cab_mov_base_imponible = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    cab_mov_iva = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    cab_mov_valor_final = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    cab_mov_estado = table.Column<bool>(type: "bit", nullable: false),
                    usu_id = table.Column<int>(type: "int", nullable: false),
                    Usuariousu_id = table.Column<int>(type: "int", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cab_Movimiento", x => x.cab_mov_id);
                    table.ForeignKey(
                        name: "FK_Cab_Movimiento_Persona_Personaper_id",
                        column: x => x.Personaper_id,
                        principalTable: "Persona",
                        principalColumn: "per_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cab_Movimiento_Tipo_Movimiento_Tipo_Movimientotip_mov_id",
                        column: x => x.Tipo_Movimientotip_mov_id,
                        principalTable: "Tipo_Movimiento",
                        principalColumn: "tip_mov_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cab_Movimiento_Usuario_Usuariousu_id",
                        column: x => x.Usuariousu_id,
                        principalTable: "Usuario",
                        principalColumn: "usu_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Det_Movimiento",
                columns: table => new
                {
                    det_mov_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cab_mov_id = table.Column<int>(type: "int", nullable: false),
                    Cab_Movimientocab_mov_id = table.Column<int>(type: "int", nullable: false),
                    pro_id = table.Column<int>(type: "int", nullable: false),
                    Productopro_id = table.Column<int>(type: "int", nullable: false),
                    det_mov_cantidad = table.Column<int>(type: "int", nullable: false),
                    det_mov_precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    det_mov_base_imponible = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    det_mov_iva = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    det_mov_total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    det_mov_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Det_Movimiento", x => x.det_mov_id);
                    table.ForeignKey(
                        name: "FK_Det_Movimiento_Cab_Movimiento_Cab_Movimientocab_mov_id",
                        column: x => x.Cab_Movimientocab_mov_id,
                        principalTable: "Cab_Movimiento",
                        principalColumn: "cab_mov_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Det_Movimiento_Producto_Productopro_id",
                        column: x => x.Productopro_id,
                        principalTable: "Producto",
                        principalColumn: "pro_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cab_Movimiento_Personaper_id",
                table: "Cab_Movimiento",
                column: "Personaper_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cab_Movimiento_Tipo_Movimientotip_mov_id",
                table: "Cab_Movimiento",
                column: "Tipo_Movimientotip_mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cab_Movimiento_Usuariousu_id",
                table: "Cab_Movimiento",
                column: "Usuariousu_id");

            migrationBuilder.CreateIndex(
                name: "IX_Det_Movimiento_Cab_Movimientocab_mov_id",
                table: "Det_Movimiento",
                column: "Cab_Movimientocab_mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Det_Movimiento_Productopro_id",
                table: "Det_Movimiento",
                column: "Productopro_id");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Categoriacat_id",
                table: "Producto",
                column: "Categoriacat_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Det_Movimiento");

            migrationBuilder.DropTable(
                name: "Cab_Movimiento");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Tipo_Movimiento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
