namespace BRASAS_GOURMET.Models
{
    public class MesaModel
    {
        public int IdMesa { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public int Total { get; internal set; }
    }
}