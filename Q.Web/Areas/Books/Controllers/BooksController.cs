using Microsoft.AspNetCore.Mvc;

namespace Q.Web.Areas.Books.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
