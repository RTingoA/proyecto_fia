using Microsoft.AspNetCore.Mvc;
using ProyectoFiaProgra1;

namespace ProyectoFiaProgra1 . Controllers
{

    public class PagosController : Controller
    {
        public IActionResult Solicitud()
        {
            return View();
        }
    }

}