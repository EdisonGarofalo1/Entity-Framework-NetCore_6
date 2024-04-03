namespace EntityFrameworkNetCore_6.Models.Entity
{
    public class Categoria
    {

        public int cat_id { get; set; }
        public string cat_descripcion { get; set; } = null!;
        public Boolean cat_estado { get; set; }
        public HashSet<Producto> Productos { get; set; } = new HashSet<Producto>();
    }
}
