using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Products.SingleOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet("filter/{p1}/{p2}/{r1}/{r2}")]
        public IQueryable<Product> GetFilter([FromRoute] int p1, [FromRoute] int p2, [FromRoute] int r1, [FromRoute] int r2)
        {
            

            if ((p1 != 0 && p2 != 0) && (r1 == 0 && r2 == 0))
            { var product = _context.Products.Where(x => (x.price >= p1 && x.price <= p2));
                return product;
            }

            else if ((p1 == 0 && p2 == 0) && (r1 != 0 && r2 != 0))
            { var product = _context.Products.Where(x => (x.RatingValue >= r1 && x.RatingValue <= r2));
                return product;
            }

            else if ((p1 != 0 && p2 != 0) && (r1 != 0 && r2 != 0))
            { var product = _context.Products.Where(x => (x.price >= p1 && x.price <= p2 && x.RatingValue >= r1 && x.RatingValue <= r2));
                return product;
            }

            else {
                return null;
            }
            
        }

        [HttpGet("attfilter/{bool1}")]
        public IQueryable<Product> GetAttFilter([FromRoute] bool bool1)
        {
                        
                var product = _context.Products.Where(x => (x.AttFanValue == bool1));
                return product;
            
            
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}