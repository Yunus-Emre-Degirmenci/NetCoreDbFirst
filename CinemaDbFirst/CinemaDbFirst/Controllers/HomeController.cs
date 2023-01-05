using CinemaDbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaDbFirst.Controllers
{
    public class HomeController : Controller
    {
        CinemaDBContext _context;
        public HomeController(CinemaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
