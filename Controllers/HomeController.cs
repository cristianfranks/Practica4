using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Practica4.Models;

namespace Practica4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ImagenContext _context;

        public HomeController(ImagenContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
             var imagenes = _context.Imagenes.Include(x => x.Comentario)
                                                .Where(x => x.FechaRegistro.AddDays(5) >= DateTime.Now)
                                                .ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
