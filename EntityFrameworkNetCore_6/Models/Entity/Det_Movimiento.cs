namespace EntityFrameworkNetCore_6.Models.Entity
{
    public class Det_Movimiento
    {

        public int det_mov_id { get; set; }
        public int cab_mov_id { get; set; }
        public Cab_Movimiento Cab_Movimiento { get; set; } = null!;
        public int pro_id { get; set; }
        public Producto Producto { get; set; } = null!;
        public int det_mov_cantidad { get; set; }
        public decimal det_mov_precio { get; set; }
        public decimal det_mov_base_imponible { get; set; }
        public decimal det_mov_iva { get; set; }
        public decimal det_mov_total { get; set; }
        public Boolean det_mov_estado { get; set; }
    }
}
