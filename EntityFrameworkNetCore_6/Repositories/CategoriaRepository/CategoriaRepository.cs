using AutoMapper;
using EntityFrameworkNetCore_6.Data;
using EntityFrameworkNetCore_6.Exceptions;
using EntityFrameworkNetCore_6.Models.Dto.CategoriaDto;
using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Repositories.CategoriaRepository
{
    public class CategoriaRepository : ICategoriaRepository
    {


        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CategoriaRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<Categoria>> GetCategoriaListAsync()
        {
            return await context.Categoria.ToListAsync();
        }


        public async Task<Categoria> GetCategoriaByIdAsync(int Id)
        {


            var response = await context.Categoria.FirstOrDefaultAsync(a => a.cat_id == Id);

            return response!;
        }

        public async Task<(int Resultado, string Mensaje)> AddCategoriaAsync(Categoria categoria)
        {

            var Existe = await context.Categoria.AnyAsync(c =>
             c.cat_descripcion == categoria.cat_descripcion);

            if (Existe)
            {
                return (0,"Ya existe la categoria con el nombre " + categoria.cat_descripcion);
            }


            context.Add(categoria);
            var resultado = await context.SaveChangesAsync();
            return (resultado, "Categoría agregada correctamente");

        }

        public async Task<(int Resultado, string Mensaje)> UpdateCategoriaAsync(Categoria categoria)
        {
            var Existe = await context.Categoria.AnyAsync(c =>
            c.cat_id == categoria.cat_id);
            if (Existe)
            {

                context.Update(categoria);
                var resulado= await context.SaveChangesAsync();
                return (resulado, "La categoria se Actualizo corretamente ");
            }
            return (0, "No  existe la categoria con el Id: " + categoria.cat_id);

        }



        public async Task<(int Resultado, string Mensaje)> DeleteCategoriaAsync(int Id)
        {

            var categoria = await context.Categoria.FirstOrDefaultAsync(a => a.cat_id == Id);

            if (categoria != null)
            {
                context.Remove(categoria);
                var resulado = await context.SaveChangesAsync();
                return (resulado, "La categoria se elimino corretamente ");
            }

            return (0, "No  existe la categoria con el Id: " + Id);

        }

        public async Task<(int Resultado, string Mensaje)> AddLotesCategoriaAsync(CategoriaDTO[] categoriaDTO)
        {
            var categorias = mapper.Map<Categoria[]>(categoriaDTO);
            context.AddRange(categorias);
            var resultado = await context.SaveChangesAsync();
            return (resultado, "Categoría agregada correctamente");



        }
    }
}
