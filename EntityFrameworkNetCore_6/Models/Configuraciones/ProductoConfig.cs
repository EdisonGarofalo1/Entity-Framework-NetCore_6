using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {

        public void Configure(EntityTypeBuilder<Producto> builder)
        {
          
            builder.HasKey(p => p.pro_id);
            builder.Property(p => p.pro_descripcion).IsRequired();
            builder.Property(p => p.pro_precio).HasPrecision(18, 2);

           builder.HasOne(p => p.Categoria)
              .WithMany(c => c.Productos)
              .HasForeignKey(p => p.cat_id)
              .HasConstraintName("FK_Producto_Categoria");


        }
    }
}
