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
    public abstract class HttpSystembolagetRepository<TEntity, TListedEntity> where TEntity : class where TListedEntity : class
    {
        private static readonly Uri BaseUri = new Uri("https://www.systembolaget.se/api/");
        protected abstract string EndPoint { get; }

        private DateTime? lastFetch;
        protected TEntity endPointData;

        protected HttpSystembolagetRepository()
        {
            UpdateEntityData().Wait();
        }


        public abstract Task<ICollection<TListedEntity>> GetCollectionAsync();

        protected async Task UpdateEntityData()
        {
            var client = new HttpClient
            {
                BaseAddress = BaseUri
            };
            var stream = await client.GetStreamAsync(EndPoint);

            var serializer = new XmlSerializer(typeof(artiklar));
            var streamReader = new StreamReader(stream);
            var entityData = (TEntity)serializer.Deserialize(streamReader);
            streamReader.Close();
            endPointData = entityData;
            lastFetch = DateTime.UtcNow;
        }

        public async Task Update()
        {
            if (!lastFetch.HasValue)
            {
                await UpdateEntityData();
                return;
            }
            var timeSinceLastFetch = lastFetch.Value - DateTime.UtcNow;
            if (timeSinceLastFetch.TotalSeconds < 60 * 60)
            {
                return;
            }

            await UpdateEntityData();
        }

    }
}
