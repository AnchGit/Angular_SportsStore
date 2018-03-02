using SportsStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    [Route("api/products")]
    public class ProductValuesController : Controller
    {
        private DataContext context;

        public ProductValuesController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public Product GetProduct(long id)
        {
            return context.Products.Find(id);
        }
    }
}