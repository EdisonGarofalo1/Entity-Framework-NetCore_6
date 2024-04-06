namespace EntityFrameworkNetCore_6.Models.Dto.ProductoDto
{
    public class CategoriaListDTO
    {
        public int cat_id { get; set; }
        public string cat_descripcion { get; set; } = null!;
        public Boolean cat_estado { get; set; }
    }
}
