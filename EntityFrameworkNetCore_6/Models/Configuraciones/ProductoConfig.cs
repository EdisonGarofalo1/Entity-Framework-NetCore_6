using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {

        public void Configure(EntityTypeBuilder<Producto> builder)
        {

            builder.HasKey(e => e.pro_id);
            builder.Property(a => a.pro_precio).HasPrecision(18, 2);



        }
    }
}
