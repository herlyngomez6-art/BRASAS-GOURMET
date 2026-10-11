using BRASAS_GOURMET.Models;
using Microsoft.AspNetCore.Mvc;

namespace BRASAS_GOURMET.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Mesas()
        {
            var mesas = new List<MesaModel>();

            for (int i = 1; i <= 40; i++)
            {
                mesas.Add(new MesaModel
                {
                    IdMesa = i,
                    Numero = i,
                    Estado = "Libre"
                });
            }

            return View(mesas);
        }

        public IActionResult TomarPedido(int idMesa, string? categoria)
        {
            var categorias = MenuData.Categorias;
            var actual = categoria ?? categorias.First();

            var vm = new TomarPedidoViewModel
            {
                IdMesa = idMesa,
                Categorias = categorias,
                CategoriaActual = actual,
                Productos = MenuData.Productos.Where(p => p.Categoria == actual).ToList()
            };

            return View(vm);
        }
    }
}