using Microsoft.AspNetCore.Mvc;
using ProyectoFiaProgra1;

namespace ProyectoFiaProgra1 . Controllers
{

    public class ServiciosController : Controller
    {
        public IActionResult Tipo()
        {
            return View();
        }
    }

}