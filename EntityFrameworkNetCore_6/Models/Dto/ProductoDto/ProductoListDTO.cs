using EntityFrameworkNetCore_6.Models.Entity;

namespace EntityFrameworkNetCore_6.Models.Dto.ProductoDto
{
    public class ProductoListDTO
    {
        public int pro_id { get; set; }
      
      
        public string pro_codigo { get; set; } = null!;
        public string pro_descripcion { get; set; } = null!;
        public decimal pro_precio { get; set; }
        public int stock { get; set; }
        public Boolean pro_lleva_iva { get; set; }
        public Boolean pro_estado { get; set; }

        public CategoriaListDTO Categoria { get; set; } = null!;
    }
}
