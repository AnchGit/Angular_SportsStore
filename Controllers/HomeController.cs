using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;

        public HomeController(DataContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Sports Store App";
            return View(context.Products.OrderBy(p => p.ProductId).First());
        }
    }
}
