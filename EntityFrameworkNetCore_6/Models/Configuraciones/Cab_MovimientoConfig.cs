using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class Cab_MovimientoConfig : IEntityTypeConfiguration<Cab_Movimiento>
    {

        public void Configure(EntityTypeBuilder<Cab_Movimiento> builder)
        {

            builder.HasKey(e => e.cab_mov_id);
            builder.Property(a => a.cab_mov_base_imponible).HasPrecision(18, 2);
            builder.Property(a => a.cab_mov_iva).HasPrecision(18, 2);
            builder.Property(a => a.cab_mov_valor_final).HasPrecision(18, 2);


        }
    }
}
