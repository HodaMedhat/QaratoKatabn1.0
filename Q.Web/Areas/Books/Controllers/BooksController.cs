using Microsoft.AspNetCore.Mvc;

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
    }
}
