using EntityFrameworkNetCore_6.Models.Dto.CategoriaDto;
using EntityFrameworkNetCore_6.Models.Entity;

namespace EntityFrameworkNetCore_6.Services.CategoriaService
{
    public interface ICategoriaService
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
