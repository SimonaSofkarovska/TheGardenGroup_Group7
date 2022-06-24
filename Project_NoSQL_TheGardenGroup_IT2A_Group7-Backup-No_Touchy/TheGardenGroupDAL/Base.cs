using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGardenGroupDAL
{
    public abstract class Base
    {
        protected static MongoClient dbClient;
        protected static IMongoDatabase db;

        public Base()
        {
            dbClient = new MongoClient("mongodb+srv://REDnas:1497@thegardengroupdb.lg8ws.mongodb.net/TheGardenGroupDB?retryWrites=true&w=majority");
            db = dbClient.GetDatabase("TheGardenGroupDB");
        }
    }
    //
}
