using CinemaDbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaDbFirst.Controllers
{
    public class MoviesController : Controller
    {
        CinemaDBContext _context;
        public MoviesController(CinemaDBContext context)
        {
            _context = context;
        }
        public IActionResult MoviesLists()
        {
            List<TblMovie> movies = _context.TblMovies.ToList();
            return View(movies);
        }
    }
}
