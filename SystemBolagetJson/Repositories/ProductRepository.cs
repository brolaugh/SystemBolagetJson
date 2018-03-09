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
    public class ProductRepository: HttpSystembolagetRepository<artiklar, artiklarArtikel>
    {
        #region Singleton

        private static readonly ProductRepository instance = new ProductRepository();

        static ProductRepository()
        {
        }

        public static ProductRepository Instance => instance;

        #endregion


        private const string _endpoint = "assortment/products/xml";

        protected override string EndPoint => _endpoint;

        public override async Task<ICollection<artiklarArtikel>> GetCollectionAsync()
        {
            await Update();
            return endPointData.artikel.ToList();
        }


    }
}
