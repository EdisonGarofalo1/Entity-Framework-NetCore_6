namespace EntityFrameworkNetCore_6.Models.Entity
{
    public class Usuario
    {
        public int usu_id { get; set; }
        public string usu_nombres { get; set; } = null!;
        public string usu_apellidos { get; set; } = null!;
        public string usu_direccion { get; set; } = null!;
        public string usu_telefono { get; set; } = null!;
        public string usu_email { get; set; } = null!;
        public string usu_usuario { get; set; } = null!;
        public string usu_clave { get; set; } = null!;
        public Boolean usu_estado { get; set; }
    }
}
