using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practica4.Models;

namespace Practica4.Controllers
{
    public class ImagenController : Controller
    {
        private readonly ImagenContext _context;
        public ImagenController(ImagenContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Registro(){
            ViewBag.Comentarios = _context.Comentarios.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            return View();
        }
        [HttpPost]
        public IActionResult Registro(Imagen i){
            if (ModelState.IsValid){
                _context.Imagenes.Add(i);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else {
                return View(i);
            }
        }
    }
}