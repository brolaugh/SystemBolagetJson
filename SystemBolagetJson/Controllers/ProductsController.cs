using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SystemBolagetJson.Models;
using SystemBolagetJson.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace SystemBolagetJson.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        public ProductsController()
        {
        }
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<artiklarArtikel>> Get() => await ProductRepository.GetCollectionAsync();

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var collection = await ProductRepository.GetCollectionAsync();
            var targetProduct = collection.SingleOrDefault(p => p.nr == id);

            if (targetProduct == null)
            {
                return NotFound();
            }

            return Ok(targetProduct);
        }
    }
}
