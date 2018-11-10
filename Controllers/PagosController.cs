using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto_Fia.Models;
using Proyecto_Fia.Context;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFiaProgra1 . Controllers
{

    public class PagosController : Controller
    {
      
    private readonly CarWashContext _context;

    public PagosController(CarWashContext _context){
            this._context = _context;
        }

        public IActionResult Solicitud()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solicitud(MensajePago m)
        {
            if (ModelState.IsValid)
            {                
                _context.Add(m);
                _context.SaveChanges();

                return RedirectToAction("Validando");
            }

            return View(m);
        }
        public IActionResult Validando()
        {
            return View();
        }


    }

}