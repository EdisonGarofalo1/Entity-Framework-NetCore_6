using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Models.Configuraciones
{
    public class PersonaConfig : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {

            builder.HasKey(e => e.per_id);



        }
    }
}
