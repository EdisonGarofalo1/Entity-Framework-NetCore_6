using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {


        public void Configure(EntityTypeBuilder<Categoria> builder)
        {

            builder.HasKey(e => e.cat_id);



        }
    }
}
