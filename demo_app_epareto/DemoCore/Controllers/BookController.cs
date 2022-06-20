using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoCore.Models;
using DemoCore.Data.DBContext;
using DemoCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoCore.Controllers
{
    public class BookController : Controller
    {
        private ILogger<BookController> _logger;
        private AppDBContext _context;

        public BookController(ILogger<BookController> logger,AppDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Welcome()
        {
            return View();
        }


        public IActionResult List(string message = "")
        {
            ViewBag.Message = message;
            var model = new ListViewModel
            {
                Books = _context.Books.Include(s => s.Authors).Include(s => s.Genres)
                    .Select(book => new BookViewModel(book)).ToList()
            };
            return View(model);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
