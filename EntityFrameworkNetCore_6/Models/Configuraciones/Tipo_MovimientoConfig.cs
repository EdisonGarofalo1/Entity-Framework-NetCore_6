using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class Tipo_MovimientoConfig : IEntityTypeConfiguration<Tipo_Movimiento>
    {
        public void Configure(EntityTypeBuilder<Tipo_Movimiento> builder)
        {

            builder.HasKey(e => e.tip_mov_id);



        }
    }
}
