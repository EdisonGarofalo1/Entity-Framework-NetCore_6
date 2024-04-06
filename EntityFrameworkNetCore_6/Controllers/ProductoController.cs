

using EntityFrameworkNetCore_6.Models.Dto.CategoriaDto;
using EntityFrameworkNetCore_6.Models.Dto.ProductoDto;
using EntityFrameworkNetCore_6.Models.Entity;
using EntityFrameworkNetCore_6.Services.ProductoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Controllers
{
    [Route("api/producto")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            this._productoService = productoService;

        }


        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<ProductoListDTO>>> Get()
        {


            try
            {

                var response = await _productoService.GetProductoListAsync();

                //if (response == null || response.Count == 0)
                //{
                //    return NotFound(); // Devolver 404 Not Found si no se encontraron categorías
                //}

                return Ok(response);
            }
            catch
            {
                return StatusCode(500, "Se produjo un error al recuperar la lista de categorías.");
            }
        }



        [HttpGet("search/{nombre}")]
        public async Task<ActionResult<IEnumerable<ProductoListDTO>>> buscarProductoNombre(string nombre)
        {


            try
            {

                var response = await _productoService.BuscarProductoNombre(nombre);

                //if (response == null || response.Count == 0)
                //{
                //    return NotFound(); // Devolver 404 Not Found si no se encontraron categorías
                //}

                return Ok(response);
            }
            catch
            {
                return StatusCode(500, "Se produjo un error al recuperar la lista de categorías.");
            }
        }


        [HttpGet("search/{Id:int}")]
        public async Task<ActionResult<ProductoListDTO>> Get(int Id)

        {

            try
            {
                if (Id <= 0)
                {
                    return BadRequest("El ID de la categoría debe ser mayor que cero.");
                }

                var response = await _productoService.GetProductoByIdAsync(Id);

                if (response == null)
                {
                    return NotFound(); // Devolver 404 Not Found si no se encuentra la categoría
                }

                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch
            {
                return StatusCode(500, "Se produjo un error al recuperar la lista de categorías.");
            }


        }


        [HttpPost("save")]
        public async Task<IActionResult> AddCategoriaAsync(ProductoSaveDTO productoDTO)
        {



            try

            {
                


                var (resultado, mensaje) = await _productoService.AddProductoAsync(productoDTO);
                if (resultado > 0)
                {

                    return Ok(new { Resultado = resultado, Mensaje = mensaje });

                }
                else
                {
                    return BadRequest(new { Resultado = resultado, Mensaje = mensaje });
                }

            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Error al guardar el producto en la base de datos.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Se produjo un error al agregar el producto.");
            }



        }


        [HttpPut("update/{Id:int}")]
        public async Task<IActionResult> UpdateCategoriaAsync(int Id, ProductoSaveDTO productoDTO)
        {
            if (Id <= 0)
            {
                return BadRequest("El ID de la producto debe ser mayor que cero.");
            }
            try
            {
               



                var (resultado, mensaje) = await _productoService.UpdateProductoAsync(Id, productoDTO);
                if (resultado > 0)
                {

                    return Ok(new { Resultado = resultado, Mensaje = mensaje });

                }
                else
                {
                    return BadRequest(new { Resultado = resultado, Mensaje = mensaje });
                }
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Error al Actualizar la producto en la base de datos.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Se produjo un error al Actualizar la producto.");
            }
        }


        [HttpDelete("delete/{Id:int}")]
        public async Task<IActionResult> DeleteCategoriaAsync(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest("El ID de la categoría debe ser mayor que cero.");
            }
            try

            {
                var (resultado, mensaje) = await _productoService.DeleteProductoAsync(Id);

                if (resultado > 0)
                {

                    return Ok(new { Resultado = resultado, Mensaje = mensaje });

                }
                else
                {
                    return BadRequest(new { Resultado = resultado, Mensaje = mensaje });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Se produjo un error al eliminar la producto."); // Devuelve 500 Internal Server Error si ocurre un error inesperado
            }
        }



        


    }
}
