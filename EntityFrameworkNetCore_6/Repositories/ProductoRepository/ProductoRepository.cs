using AutoMapper;
using EntityFrameworkNetCore_6.Data;
using EntityFrameworkNetCore_6.Models.Dto.ProductoDto;
using EntityFrameworkNetCore_6.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Repositories.ProductoRepository
{
    public class ProductoRepository : IProductoRepository
    {

        private readonly ApplicationDbContext context;
        //private readonly IMapper mapper;

        public ProductoRepository(ApplicationDbContext context)
        {
            this.context = context;
            //this.mapper = mapper;
        }


        public async Task<List<ProductoListDTO>> GetProductoListAsync()
    
        {
           var productoDTO = await context.Producto
                 .Select(pro => new ProductoListDTO
                 {
                    pro_id= pro.pro_id,
                     pro_codigo=  pro.pro_codigo,
                     pro_descripcion = pro.pro_descripcion,
                     pro_precio= pro.pro_precio,
                     stock=  pro.stock,
                     pro_lleva_iva= pro.pro_lleva_iva,
                     pro_estado= pro.pro_estado,
                     Categoria =   new CategoriaListDTO
                     {
                        cat_id= pro.Categoria.cat_id,
                         cat_descripcion= pro.Categoria.cat_descripcion,
                         cat_estado=pro.Categoria.cat_estado

                     } 
                 })
                .ToListAsync();

            return productoDTO;
      
        }

        public async Task<ProductoListDTO> GetProductoByIdAsync(int Id)
        {
            var response = await context.Producto
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(p => p.pro_id == Id);

            if (response == null)
            {
                return null; 
            }
            var productoDTO = new ProductoListDTO
            {
                pro_id = response.pro_id,
                pro_codigo = response.pro_codigo,
                pro_descripcion = response.pro_descripcion,
                pro_precio = response.pro_precio,
                stock = response.stock,
                pro_lleva_iva = response.pro_lleva_iva,
                pro_estado = response.pro_estado,
                Categoria = new CategoriaListDTO
                {
                    cat_id = response.Categoria.cat_id,
                    cat_descripcion = response.Categoria.cat_descripcion,
                    cat_estado = response.Categoria.cat_estado

                }


            };


            return productoDTO;
        }

        public async Task<(int Resultado, string Mensaje)> AddProductoAsync(ProductoSaveDTO productoDTO)
        {

            var Existe = await context.Producto.AnyAsync(p =>
            p.pro_codigo == productoDTO.pro_codigo);

            if (Existe)
            {
                return (0, "Ya existe el codigo barra  " + productoDTO.pro_codigo);
            }
           
            var producto = new Producto
            {
                pro_codigo = productoDTO.pro_codigo,
                pro_descripcion = productoDTO.pro_descripcion,
                pro_precio = productoDTO.pro_precio,
                stock = productoDTO.stock,
                pro_lleva_iva = productoDTO.pro_lleva_iva,
                pro_estado = productoDTO.pro_estado,
                cat_id = productoDTO.cat_id
            };


            context.Add(producto);
            var resultado = await context.SaveChangesAsync();
            return (resultado, "Producto agregada correctamente");

        }

        public async Task<(int Resultado, string Mensaje)> UpdateProductoAsync(int Id, ProductoSaveDTO productoDTO)
        {

            var Existe = await context.Producto.AnyAsync(p =>
           p.pro_id == Id);
            if (Existe)
            {

                var producto = new Producto
                {
                    pro_id=Id,
                    pro_codigo = productoDTO.pro_codigo,
                    pro_descripcion = productoDTO.pro_descripcion,
                    pro_precio = productoDTO.pro_precio,
                    stock = productoDTO.stock,
                    pro_lleva_iva = productoDTO.pro_lleva_iva,
                    pro_estado = productoDTO.pro_estado,
                    cat_id = productoDTO.cat_id
                };

                context.Update(producto);
                var resulado = await context.SaveChangesAsync();
                return (resulado, "La producto se Actualizo corretamente ");
            }
            return (0, "No  existe la producto con el Id: " + Id);

        }

        public async Task<(int Resultado, string Mensaje)> DeleteProductoAsync(int Id)
        {

            var producto = await context.Producto.FirstOrDefaultAsync(p=> p.pro_id == Id);

            if (producto != null)
            {
                context.Remove(producto);
                var resulado = await context.SaveChangesAsync();
                return (resulado, "La producto se elimino corretamente ");
            }

            return (0, "No  existe la producto con el Id: " + Id);
        }

        public async Task<List<ProductoListDTO>> BuscarProductoNombre(string nombre)
        {
            
              var productoDTO = await context.Producto
                .Include(pro => pro.Categoria)
        .Where(pro => pro.pro_descripcion.Contains(nombre))
        .Select(pro => new ProductoListDTO
        {
            pro_id = pro.pro_id,
            pro_codigo = pro.pro_codigo,
            pro_descripcion = pro.pro_descripcion,
            pro_precio = pro.pro_precio,
            stock = pro.stock,
            pro_lleva_iva = pro.pro_lleva_iva,
            pro_estado = pro.pro_estado,
            Categoria = new CategoriaListDTO
            {
                cat_id = pro.Categoria.cat_id,
                cat_descripcion = pro.Categoria.cat_descripcion,
                cat_estado = pro.Categoria.cat_estado

            }
        })
        .ToListAsync();

           return productoDTO;

        }
    }
}
