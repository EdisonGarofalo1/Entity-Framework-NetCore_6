namespace EntityFrameworkNetCore_6.Models.Entity
{
    public class Cab_Movimiento
    {
        public int cab_mov_id { get; set; }
        public int cab_mov_num_doc { get; set; }
        public int tip_mov_id { get; set; }
        public Tipo_Movimiento Tipo_Movimiento { get; set; } = null!;
        public string cab_movimiento { get; set; } = null!;
        public int per_id { get; set; }
        public Persona Persona { get; set; } = null!;
        public DateTime cab_mov_fecha { get; set; }
        public decimal cab_mov_base_imponible { get; set; }
        public decimal cab_mov_iva { get; set; }
        public decimal cab_mov_valor_final { get; set; }
        public Boolean cab_mov_estado { get; set; }
        public int usu_id { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public DateTime fecha_registro { get; set; }
        public DateTime fecha_modificacion { get; set; }
        public List<Det_Movimiento> Det_Movimientos { get; set; } = new List<Det_Movimiento>();
    }
}
