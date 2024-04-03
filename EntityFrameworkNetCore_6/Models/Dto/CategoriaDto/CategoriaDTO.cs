using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkNetCore_6.Models.Dto.CategoriaDto
{
    public class CategoriaDTO
    {

       
        [Required(ErrorMessage = "El campo descripcion es obligatorio.")]
        [StringLength(maximumLength: 200)]
        public string cat_descripcion { get; set; } = null!;
        public Boolean cat_estado { get; set; }
    }
}
