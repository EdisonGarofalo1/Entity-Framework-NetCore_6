using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class Cab_MovimientoConfig : IEntityTypeConfiguration<Cab_Movimiento>
    {

        public void Configure(EntityTypeBuilder<Cab_Movimiento> builder)
        {

            builder.HasKey(cab_mov => cab_mov.cab_mov_id);
            builder.Property(cab_mov => cab_mov.cab_mov_base_imponible).HasPrecision(18, 2);
            builder.Property(cab_mov => cab_mov.cab_mov_iva).HasPrecision(18, 2);
            builder.Property(cab_mov => cab_mov.cab_mov_valor_final).HasPrecision(18, 2);

            builder.HasOne(cab_mov => cab_mov.Tipo_Movimiento)
         .WithMany(tipo_mov => tipo_mov.Cab_Movimientos)
         .HasForeignKey(cab_mov => cab_mov.tip_mov_id)
         .HasConstraintName("FK_Cab_Movimiento_Tipo_Movimiento");


            builder.HasOne(cab_mov => cab_mov.Persona)
         .WithMany(per => per.Cab_Movimientos)
       .HasForeignKey(cab_mov => cab_mov.per_id)
       .HasConstraintName("FK_Cab_Movimiento_Persona");

            builder.HasOne(cab_mov => cab_mov.Usuario)
        .WithMany(usu => usu.Cab_Movimientos)
      .HasForeignKey(cab_mov => cab_mov.usu_id)
      .HasConstraintName("FK_Cab_Movimiento_Usuario");

        }
    }
}
