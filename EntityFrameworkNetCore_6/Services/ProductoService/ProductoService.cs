using EntityFrameworkNetCore_6.Models.Dto.ProductoDto;
using EntityFrameworkNetCore_6.Models.Entity;
using EntityFrameworkNetCore_6.Repositories.ProductoRepository;


namespace EntityFrameworkNetCore_6.Services.ProductoService
{
    public class ProductoService : IProductoService
    {

        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {

            _repository = repository;
        }

        public async Task<List<ProductoListDTO>> GetProductoListAsync()
        {
            return await _repository.GetProductoListAsync();
        }

        public async Task<ProductoListDTO> GetProductoByIdAsync(int Id)
        {
            return await _repository.GetProductoByIdAsync(Id);
        }

        public async Task<(int Resultado, string Mensaje)> AddProductoAsync(ProductoSaveDTO productoDTO)
        {
            return await _repository.AddProductoAsync(productoDTO);

        }

        public async Task<(int Resultado, string Mensaje)> UpdateProductoAsync(int Id, ProductoSaveDTO productoDTO)
        {
            return await _repository.UpdateProductoAsync(Id, productoDTO);
        }

        public async Task<(int Resultado, string Mensaje)> DeleteProductoAsync(int Id)
        {
            return await _repository.DeleteProductoAsync(Id);
        }

        public async Task<List<ProductoListDTO>> BuscarProductoNombre(string nombre)
        {
            return await _repository.BuscarProductoNombre(nombre);
        }
    }
}
