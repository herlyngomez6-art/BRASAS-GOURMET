namespace BRASAS_GOURMET.Models
{
    public class ProductoMenu
    {
        public string Categoria { get; set; } = "";
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
    }

    public class TomarPedidoViewModel
    {
        public int IdMesa { get; set; }
        public List<string> Categorias { get; set; } = new();
        public string CategoriaActual { get; set; } = "";
        public List<ProductoMenu> Productos { get; set; } = new();
    }
}