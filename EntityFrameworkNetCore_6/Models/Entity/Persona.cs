namespace EntityFrameworkNetCore_6.Models.Entity
{
    public class Persona
    {
        public int per_id { get; set; }

        public string per_identificacion { get; set; } = null!;

        public int cp_sexo { get; set; }

        public int cp_estado_civil { get; set; }

        public string per_nombres { get; set; } = null!;

        public string per_telefono { get; set; } = null!;

        public string per_direccion { get; set; } = null!;

        public Boolean per_estado { get; set; }

        public List<Cab_Movimiento> Cab_Movimientos { get; set; } = new List<Cab_Movimiento>();
    }
}
