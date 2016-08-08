using System.Configuration;
using MongoDB.Driver;

namespace DAL.Mongo
{
    public class MongoConnectionHandler
    {
        const string dbName = "minioccuro";

        private static IMongoDatabase Database;

        public static IMongoDatabase GetDatabase()
        {
            if (Database == null)
            {
                var connectionString = "mongodb://localhost";

                var client = new MongoClient(connectionString);
                Database = client.GetDatabase(dbName);
            }

            return Database;
        }
    }
}
