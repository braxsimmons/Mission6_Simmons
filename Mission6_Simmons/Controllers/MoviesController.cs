using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_Simmons.Models;

namespace Mission6_Simmons.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: List all movies
        public IActionResult ListMovies()
        {
            var movies = _context.Movies.Include(m => m.Category)
                .ToList();
            return View(movies);
        }

        // GET: Show form to add a new movie
        public IActionResult AddMovie()
        {
            return View(new MovieModel()); 
        }

        // POST: Add a new movie
        [HttpPost]
        public IActionResult AddMovie(MovieModel movie)
        {
                _context.Movies.Add(movie);
                _context.SaveChanges(); 

            return RedirectToAction("ListMovies");
        }

        public IActionResult Edit(int id)

        {
            var recordToEdit = _context.Movies.Include("Category")
                .Where(x => x.MovieId == id)
                .FirstOrDefault();
            ViewBag.C = _context.Categories.ToList();

            return View("EditMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel m)
        {
            _context.Update(m);
            _context.SaveChanges();

            return RedirectToAction("ListMovies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Where(x => x.MovieId == id)
                .FirstOrDefault();

            return View(recordToDelete);
        }

        [HttpPost]

        public IActionResult Delete(MovieModel model)
        {
            _context.Movies.Remove(model);
            _context.SaveChanges();

            return RedirectToAction("ListMovies");
        }
    }
}
   