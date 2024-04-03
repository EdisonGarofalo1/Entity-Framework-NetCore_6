using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class Det_MovimientoConfig : IEntityTypeConfiguration<Det_Movimiento>

    {
        public void Configure(EntityTypeBuilder<Det_Movimiento> builder)
        {

            builder.HasKey(e => e.det_mov_id);

            builder.Property(a => a.det_mov_precio).HasPrecision(18, 2);
            builder.Property(a => a.det_mov_base_imponible).HasPrecision(18, 2);
            builder.Property(a => a.det_mov_iva).HasPrecision(18, 2);
            builder.Property(a => a.det_mov_total).HasPrecision(18, 2);



        }

    }
}
