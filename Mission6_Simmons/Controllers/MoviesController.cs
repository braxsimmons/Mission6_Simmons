using Microsoft.AspNetCore.Mvc;
using Mission6_Simmons.Models; // Make sure this using directive matches your project's namespace
using System.Threading.Tasks;

namespace Mission6_Simmons.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor injects the ApplicationDbContext
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET action to display the form for adding a new movie
        public IActionResult AddMovie()
        {
            return View(new MovieModel()); // Provide a new, empty MovieModel to the view
        }

        // POST action to process the form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitForm(MovieModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(model); // Add the movie to the database context
                await _context.SaveChangesAsync(); // Save changes asynchronously

                TempData["SuccessMessage"] = "Movie submitted successfully!";
                return RedirectToAction("AddMovie"); // Redirect back to clear the form
            }
            return View("AddMovie", model); // If model state is invalid, return with validation feedback
        }
    }
}
