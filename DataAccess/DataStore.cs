using ConnectedBus.Models;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataStore : IDataStore
    {
        public void Write<T>(T data) where T : IHaveAnId
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("test");

            var collection = database.GetCollection<T>(data.GetType().Name.ToLower());
            var query = Query<T>.EQ(t => t.Id, data.Id);

            var theThing = collection.FindOne(query);
            if(theThing != null)
            {
                Console.WriteLine("found id {0}", theThing.Id);
                theThing = data;
            }
            collection.Save(theThing);
        }

        public T Read<T>(string key)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("test");

            var collection = database.GetCollection<T>(typeof(T).Name.ToLower());

            return default(T);
            
        }
    }
}
