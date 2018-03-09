using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SystemBolagetJson.Models;

namespace SystemBolagetJson.Repositories
{
    public static class ProductRepository//: IRepository<artiklarArtikel>
    {
        private static DateTime? lastFetch;
        private static List<artiklarArtikel> productList;

        public static async Task<ICollection<artiklarArtikel>> GetCollectionAsync()
        {
            await Update();
            return productList;
        }

        private static async Task UpdateProductList()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://www.systembolaget.se/api/")
            };
            var stream = await client.GetStreamAsync("assortment/products/xml");

            var serializer = new XmlSerializer(typeof(artiklar));
            var streamReader = new StreamReader(stream);
            var articles = (artiklar)serializer.Deserialize(streamReader);
            streamReader.Close();
            productList = articles.artikel.ToList();
            lastFetch = DateTime.UtcNow;
        }

        public static async Task Update()
        {
            if (!lastFetch.HasValue)
            {
                await UpdateProductList();
                return;
            }
            var timeSinceLastFetch = lastFetch.Value - DateTime.UtcNow;
            if (timeSinceLastFetch.TotalSeconds < 60 * 60)
            {
                return;
            }

            await UpdateProductList();
        }


    }
}
