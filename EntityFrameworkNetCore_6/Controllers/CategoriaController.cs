using EntityFrameworkNetCore_6.Data;
using EntityFrameworkNetCore_6.Models.Dto.CategoriaDto;
using EntityFrameworkNetCore_6.Models.Entity;
using EntityFrameworkNetCore_6.Repositories.CategoriaRepository;
using EntityFrameworkNetCore_6.Services.CategoriaService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkNetCore_6.Controllers
{
  
    [ApiController]
    [Route("api/categoria")]
    public class CategoriaController : ControllerBase
    {
       
        private readonly ICategoriaService _CategoriaService;

        public CategoriaController(ICategoriaService CategoriaService)
        {
            this._CategoriaService = CategoriaService;

        }

        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<Categoria>>> Get()
        {
       

            try
            {

                var response = await _CategoriaService.GetCategoriaListAsync();

                if (response == null || response.Count == 0)
                {
                    return NotFound(); // Devolver 404 Not Found si no se encontraron categorías
                }

                return Ok(response);
            }
            catch
            {
                return StatusCode(500, "Se produjo un error al recuperar la lista de categorías.");
            }
        }

        [HttpGet("search/{Id:int}")]
        public async Task<ActionResult<Categoria>> Get(int Id)

        {

            try
            {
                if (Id <= 0)
                {
                    return BadRequest("El ID de la categoría debe ser mayor que cero.");
                }

                var response = await _CategoriaService.GetCategoriaByIdAsync(Id);

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
        public async Task<IActionResult> AddCategoriaAsync(CategoriaDTO categoriaDTO)
        {
          
             

            try

            {
                var categoria = new Categoria
                {
                    cat_descripcion = categoriaDTO.cat_descripcion,
                    cat_estado = categoriaDTO.cat_estado

                };


                var (resultado, mensaje) = await _CategoriaService.AddCategoriaAsync(categoria);
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
                return StatusCode(500, "Error al guardar la categoría en la base de datos.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Se produjo un error al agregar la categoría.");
            }



        }


        [HttpPut("update/{Id:int}")]
        public async Task<IActionResult> UpdateCategoriaAsync(int Id, CategoriaDTO categoriaDTO)
        {
            if (Id <= 0)
            {
                return BadRequest("El ID de la categoría debe ser mayor que cero.");
            }
            try
            {
                var categoria = new Categoria
                {
                    cat_id=Id,
                    cat_descripcion = categoriaDTO.cat_descripcion,
                    cat_estado = categoriaDTO.cat_estado

                };



                var (resultado, mensaje) = await _CategoriaService.UpdateCategoriaAsync(categoria);
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
                return StatusCode(500, "Error al Actualizar la categoría en la base de datos.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Se produjo un error al Actualizar la categoría.");
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
                var (resultado, mensaje) = await _CategoriaService.DeleteCategoriaAsync(Id);

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
                return StatusCode(500, "Se produjo un error al eliminar la categoría."); // Devuelve 500 Internal Server Error si ocurre un error inesperado
            }
        }






        [HttpPost("savelist")]
        public async Task<IActionResult> AddListCategoriaAsync(CategoriaDTO[] categoriaDTO)
        {





            try

            {



                var (resultado, mensaje) = await _CategoriaService.AddLotesCategoriaAsync(categoriaDTO);
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
                return StatusCode(500, "Error al guardar la categoría en la base de datos.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Se produjo un error al agregar la categoría.");
            }



        }

    }
}
