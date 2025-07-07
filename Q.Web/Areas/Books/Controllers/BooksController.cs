using Microsoft.AspNetCore.Mvc;
using Q.VM.ViewModels;

namespace Q.Web.Areas.Books.Controllers
{
    public class BooksController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost("api/books")]
        ///books/create
        public IActionResult CreateBook([FromBody] BooksDetailVM model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // TODO: Map and save model to DB, e.g. via EF Core

            return Ok(new { message = "Book created successfully!" });
        }
    }
}
