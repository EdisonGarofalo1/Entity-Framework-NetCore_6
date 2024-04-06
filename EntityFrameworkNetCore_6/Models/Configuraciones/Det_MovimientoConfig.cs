using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class Det_MovimientoConfig : IEntityTypeConfiguration<Det_Movimiento>

    {
        public void Configure(EntityTypeBuilder<Det_Movimiento> builder)
        {

            builder.HasKey(det_mov => det_mov.det_mov_id);

            builder.Property(det_mov => det_mov.det_mov_precio).HasPrecision(18, 2);
            builder.Property(det_mov => det_mov.det_mov_base_imponible).HasPrecision(18, 2);
            builder.Property(det_mov => det_mov.det_mov_iva).HasPrecision(18, 2);
            builder.Property(det_mov => det_mov.det_mov_total).HasPrecision(18, 2);


            builder.HasOne(det_mov => det_mov.Cab_Movimiento)
         .WithMany(cab_mov => cab_mov.Det_Movimientos)
         .HasForeignKey(det_mov => det_mov.cab_mov_id)
         .HasConstraintName("FK_Det_Movimiento_Cab_Movimiento");



            builder.HasOne(det_mov => det_mov.Producto)
         .WithMany(pro => pro.Det_Movimientos)
         .HasForeignKey(det_mov => det_mov.pro_id)
         .HasConstraintName("FK_Det_Movimiento_Producto");


        }

    }
}
