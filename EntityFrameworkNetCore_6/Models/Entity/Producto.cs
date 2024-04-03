namespace EntityFrameworkNetCore_6.Models.Entity
{
    public class Producto
    {
        public int pro_id { get; set; }
        public int cat_id { get; set; }
        public Categoria Categoria { get; set; } = null!;
        public string pro_codigo { get; set; } = null!;
        public string pro_descripcion { get; set; } = null!;
        public decimal pro_precio { get; set; }
        public int stock { get; set; }
        public Boolean pro_lleva_iva { get; set; }
        public Boolean pro_estado { get; set; }


        public List<Det_Movimiento> Det_Movimientos { get; set; } = new List<Det_Movimiento>();
    }
}
