using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProficiencyAssessment.Models;

namespace ProficiencyAssessment.Controllers
{
    [ApiController]
    [Route("api/ProductsController")]
    [EnableCors("ReactPolicy")]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult Get()
        {
            var products = new Product[]
            {
                new Product { ProductId = 1, Name = "Tomato Soup", Category = 2, Price = 1 },
                new Product { ProductId = 2, Name = "Yo-yo", Category = 1, Price = 3.75 },
                new Product { ProductId = 3, Name = "Hammer", Category = 2, Price = 16.99 }
            };
            return Ok(products);
        }
    }
}