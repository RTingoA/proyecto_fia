using Microsoft.AspNetCore.Mvc;
using Proyecto_Fia.Models;

namespace Proyecto_Fia.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Ver(int id)
        {

            return View();
        }
    }
}