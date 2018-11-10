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
            PreCargaDeDatos();
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
            PreCargaDeDatos();
            return View(m);
        }
        public IActionResult Validando()
        {
            return View();
        }


        private void PreCargaDeDatos() {
            ViewBag.MensajePagos = new SelectList(_context.MensajePagos, "Id", "Nombre");
        }




         public IActionResult Solicitudes() {


                return View(_context.MensajePagos.ToList());

            
        }



        public IActionResult Detalles(int id = 0) {

            MensajePago m = _context.MensajePagos.Find(id);
            if(m == null){
                return HttpNotFound();

            }  

            return View(m);
        }

        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }

}