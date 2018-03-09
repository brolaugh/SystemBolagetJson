using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SystemBolagetJson.Models;
using Microsoft.AspNetCore.Mvc;

namespace SystemBolagetJson.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<artiklarArtikel>> Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.systembolaget.se/api/");
            var stream = await client.GetStreamAsync("assortment/products/xml");

            var serializer = new XmlSerializer(typeof(artiklar));
            var streamReader = new StreamReader(stream);
            var articles = (artiklar) serializer.Deserialize(streamReader);
            streamReader.Close();

            return articles.artikel.Reverse().Take(50);


            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
