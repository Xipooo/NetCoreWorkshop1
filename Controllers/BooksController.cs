using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCoreWorkshop1.Contexts;
using NetCoreWorkshop1.Models;

namespace NetCoreWorkshop1.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly NetCoreWorkshopContext _context;

        public BooksController(NetCoreWorkshopContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var allBooks = _context.Books;
            return Json(allBooks);
        }

        [HttpGet("[action]")]
        public IActionResult GetAuthors()
        {
            
            var books = _context.Books.ToList();
            var authorNames = books.Select(
                book => new {FirstName = book.Author.FirstName, LastName = book.Author.LastName }
            );
            return Json(authorNames);
        }
    }
}