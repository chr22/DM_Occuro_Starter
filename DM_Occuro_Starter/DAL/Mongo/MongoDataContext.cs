using System;
using MongoDB.Driver;

namespace DAL.Mongo
{
    public class MongoDataContext<T> : IDisposable
    {
        public IMongoCollection<T> MongoCollection { get; private set; }

        public MongoDataContext(string collectionName = null)
        {
            var db = MongoConnectionHandler.GetDatabase();
            
            string strCollectionName = null;

            if (!string.IsNullOrEmpty(collectionName))
            {
                strCollectionName = collectionName;
            }
            else
            {
                strCollectionName = typeof (T).Name.ToLower() + "s";
            }

            //Get collection (Collection is a table (sort of))
            //We make a collection for each Model (that inherits from entity) (with an s on the end)
            //If the collection does not exist, it will be created
            this.MongoCollection = db.GetCollection<T>(strCollectionName);
        }

        public void Dispose()
        {
            //Nothing to clean up
        }
    }
}
