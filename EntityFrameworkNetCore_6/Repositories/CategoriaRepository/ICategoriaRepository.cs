using EntityFrameworkNetCore_6.Models.Dto.CategoriaDto;
using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkNetCore_6.Repositories.CategoriaRepository
{
    public interface ICategoriaRepository
    {

        public Task<List<Categoria>> GetCategoriaListAsync();

        //public Task<IEnumerable<Categoria>> GetCategoriaByIdAsync(int Id);
        public Task<Categoria> GetCategoriaByIdAsync(int Id);
        public Task<(int Resultado, string Mensaje)> AddCategoriaAsync(Categoria categoria);
        public Task<(int Resultado, string Mensaje)> AddLotesCategoriaAsync(CategoriaDTO[] categoriaDTO);
        public Task<(int Resultado, string Mensaje)> UpdateCategoriaAsync(Categoria categoria);
        public Task<(int Resultado, string Mensaje)> DeleteCategoriaAsync(int Id);
    }
}
