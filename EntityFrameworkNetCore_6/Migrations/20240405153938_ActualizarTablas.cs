using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkNetCore_6.Migrations
{
    public partial class ActualizarTablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cab_Movimiento_Persona_Personaper_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Cab_Movimiento_Tipo_Movimiento_Tipo_Movimientotip_mov_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Cab_Movimiento_Usuario_Usuariousu_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Det_Movimiento_Cab_Movimiento_Cab_Movimientocab_mov_id",
                table: "Det_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Det_Movimiento_Producto_Productopro_id",
                table: "Det_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Det_Movimiento_Cab_Movimientocab_mov_id",
                table: "Det_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Det_Movimiento_Productopro_id",
                table: "Det_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Cab_Movimiento_Personaper_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Cab_Movimiento_Tipo_Movimientotip_mov_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Cab_Movimiento_Usuariousu_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropColumn(
                name: "Cab_Movimientocab_mov_id",
                table: "Det_Movimiento");

            migrationBuilder.DropColumn(
                name: "Productopro_id",
                table: "Det_Movimiento");

            migrationBuilder.DropColumn(
                name: "Personaper_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropColumn(
                name: "Tipo_Movimientotip_mov_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropColumn(
                name: "Usuariousu_id",
                table: "Cab_Movimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Det_Movimiento_cab_mov_id",
                table: "Det_Movimiento",
                column: "cab_mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Det_Movimiento_pro_id",
                table: "Det_Movimiento",
                column: "pro_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cab_Movimiento_per_id",
                table: "Cab_Movimiento",
                column: "per_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cab_Movimiento_tip_mov_id",
                table: "Cab_Movimiento",
                column: "tip_mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cab_Movimiento_usu_id",
                table: "Cab_Movimiento",
                column: "usu_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cab_Movimiento_Persona",
                table: "Cab_Movimiento",
                column: "per_id",
                principalTable: "Persona",
                principalColumn: "per_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cab_Movimiento_Tipo_Movimiento",
                table: "Cab_Movimiento",
                column: "tip_mov_id",
                principalTable: "Tipo_Movimiento",
                principalColumn: "tip_mov_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cab_Movimiento_Usuario",
                table: "Cab_Movimiento",
                column: "usu_id",
                principalTable: "Usuario",
                principalColumn: "usu_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Det_Movimiento_Cab_Movimiento",
                table: "Det_Movimiento",
                column: "cab_mov_id",
                principalTable: "Cab_Movimiento",
                principalColumn: "cab_mov_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Det_Movimiento_Producto",
                table: "Det_Movimiento",
                column: "pro_id",
                principalTable: "Producto",
                principalColumn: "pro_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cab_Movimiento_Persona",
                table: "Cab_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Cab_Movimiento_Tipo_Movimiento",
                table: "Cab_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Cab_Movimiento_Usuario",
                table: "Cab_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Det_Movimiento_Cab_Movimiento",
                table: "Det_Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Det_Movimiento_Producto",
                table: "Det_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Det_Movimiento_cab_mov_id",
                table: "Det_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Det_Movimiento_pro_id",
                table: "Det_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Cab_Movimiento_per_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Cab_Movimiento_tip_mov_id",
                table: "Cab_Movimiento");

            migrationBuilder.DropIndex(
                name: "IX_Cab_Movimiento_usu_id",
                table: "Cab_Movimiento");

            migrationBuilder.AddColumn<int>(
                name: "Cab_Movimientocab_mov_id",
                table: "Det_Movimiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Productopro_id",
                table: "Det_Movimiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Personaper_id",
                table: "Cab_Movimiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tipo_Movimientotip_mov_id",
                table: "Cab_Movimiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Usuariousu_id",
                table: "Cab_Movimiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Det_Movimiento_Cab_Movimientocab_mov_id",
                table: "Det_Movimiento",
                column: "Cab_Movimientocab_mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Det_Movimiento_Productopro_id",
                table: "Det_Movimiento",
                column: "Productopro_id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Cab_Movimiento_Persona_Personaper_id",
                table: "Cab_Movimiento",
                column: "Personaper_id",
                principalTable: "Persona",
                principalColumn: "per_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cab_Movimiento_Tipo_Movimiento_Tipo_Movimientotip_mov_id",
                table: "Cab_Movimiento",
                column: "Tipo_Movimientotip_mov_id",
                principalTable: "Tipo_Movimiento",
                principalColumn: "tip_mov_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cab_Movimiento_Usuario_Usuariousu_id",
                table: "Cab_Movimiento",
                column: "Usuariousu_id",
                principalTable: "Usuario",
                principalColumn: "usu_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Det_Movimiento_Cab_Movimiento_Cab_Movimientocab_mov_id",
                table: "Det_Movimiento",
                column: "Cab_Movimientocab_mov_id",
                principalTable: "Cab_Movimiento",
                principalColumn: "cab_mov_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Det_Movimiento_Producto_Productopro_id",
                table: "Det_Movimiento",
                column: "Productopro_id",
                principalTable: "Producto",
                principalColumn: "pro_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
