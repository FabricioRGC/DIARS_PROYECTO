namespace DIARS_S8.Models
{
    public class ClienteCopia
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion {  get; set; }
        public string Ciudad {  get; set; }
        public int? IdTipoCliente { get; set; }
        public int? EstCliente { get; set; }
    }
}
