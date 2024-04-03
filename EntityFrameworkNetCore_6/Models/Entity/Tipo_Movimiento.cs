namespace EntityFrameworkNetCore_6.Models.Entity
{
    public class Tipo_Movimiento
    {
        public int tip_mov_id { get; set; }
        public string tip_mov_descripcion { get; set; } = null!;
        public Boolean tip_mov_estado { get; set; }
        public List<Cab_Movimiento> Cab_Movimientos { get; set; } = new List<Cab_Movimiento>();

    }
}
