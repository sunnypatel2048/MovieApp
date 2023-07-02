using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Models;
using MovieApp.ViewModels;
using System.Diagnostics;

namespace MovieApp.Controllers
{
    /// <summary>The HomeController Class</summary>
    public class HomeController : Controller
    {
        /// <summary>The context</summary>
        private readonly MovieDataContext _context;

        /// <summary>Initializes a new instance of the <see cref="HomeController" /> class.</summary>
        public HomeController(MovieDataContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var movies  = this._context.Movies.Include(m => m.Actors).Select(m => new MovieViewModel
            {
                Title = m.Title,
                Year = m.Year.ToString(),
                Summary = m.Summary,
                Actors = string.Join(',', m.Actors.Select(a => a.FullName)),
                Directors = string.Join(',', m.Directors.Select(d => d.FullName))
            });

            return View(movies);
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