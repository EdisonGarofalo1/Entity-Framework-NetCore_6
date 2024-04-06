using EntityFrameworkNetCore_6.Models.Dto.ProductoDto;
using EntityFrameworkNetCore_6.Models.Entity;

namespace EntityFrameworkNetCore_6.Services.ProductoService
{
    public interface IProductoService
    {

        public Task<List<ProductoListDTO>> GetProductoListAsync();


        public Task<ProductoListDTO> GetProductoByIdAsync(int Id);
         public Task<(int Resultado, string Mensaje)> AddProductoAsync(ProductoSaveDTO productoDTO);

        public Task<(int Resultado, string Mensaje)> UpdateProductoAsync(int Id, ProductoSaveDTO productoDTO);
        public Task<(int Resultado, string Mensaje)> DeleteProductoAsync(int Id);
        public Task<List<ProductoListDTO>> BuscarProductoNombre(string nombre);
    }
}
