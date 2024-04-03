using EntityFrameworkNetCore_6.Models.Dto.CategoriaDto;
using EntityFrameworkNetCore_6.Models.Entity;
using EntityFrameworkNetCore_6.Repositories.CategoriaRepository;

namespace EntityFrameworkNetCore_6.Services.CategoriaService
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {

            _repository = repository;
        }
        public async Task<List<Categoria>> GetCategoriaListAsync()
        {
            return await _repository.GetCategoriaListAsync();
        }

        public async Task<(int Resultado, string Mensaje)> AddCategoriaAsync(Categoria categoria)
        {
            return await _repository.AddCategoriaAsync(categoria);
        }

        public async Task<(int Resultado, string Mensaje)> DeleteCategoriaAsync(int Id)
        {
            return await _repository.DeleteCategoriaAsync(Id);
        }

        public async Task<Categoria> GetCategoriaByIdAsync(int Id)
        {
            return await _repository.GetCategoriaByIdAsync(Id);
        }

        public async Task<(int Resultado, string Mensaje)> UpdateCategoriaAsync(Categoria categoria)
        {
            return await _repository.UpdateCategoriaAsync(categoria);
        }

        public async Task<(int Resultado, string Mensaje)> AddLotesCategoriaAsync(CategoriaDTO[] categoriaDTO)
        {
            return await _repository.AddLotesCategoriaAsync(categoriaDTO);
        }
    }
}
