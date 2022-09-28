using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReservas.Repositories
{
    public class MongoDBRepository
    {

        public MongoClient client;

        public IMongoDatabase db;

        public MongoDBRepository()
        {

            client = new MongoClient("mongodb://redbici:9JNGax2jpUSSrmexgP0x6PcRQkTk6XgKkatNz9hWTtz9fqDIwf3aBzZim97cgPrI3CwesMfftxg5kMae3w5Sww==@redbici.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@redbici@");

            db = client.GetDatabase("RedBici");
           

        }

    }
}
