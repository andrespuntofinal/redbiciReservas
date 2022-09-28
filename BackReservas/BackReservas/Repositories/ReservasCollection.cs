using BackReservas.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BackReservas.Models.CBicicletas;

namespace BackReservas.Repositories
{
    public class ReservasCollection : IReservasCollection
    {

        internal MongoDBRepository _repository = new MongoDBRepository();

        private IMongoCollection<Reservas> collection;

        public ReservasCollection()
        {

            collection = _repository.db.GetCollection<Reservas>("Reservas");

        }

        public async Task DeleteReservas(string id)
        {

            var filter = Builders<Reservas>.Filter.Eq(s => s.Id, id.ToString());

            await collection.DeleteOneAsync(filter);
        }

        public async Task<List<Reservas>> GetAllReservas()
        {
            return await collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<Reservas> GetReservaById(string id)
        {
            return await collection.FindAsync(
                    new BsonDocument { { "_id", new ObjectId(id) } }).Result.
                    FirstAsync();
        }

        public async Task InsertReservas(Reservas reserva)
        {
            await collection.InsertOneAsync(reserva);
        }

        public async Task UpdateReservas(Reservas reserva)
        {
            var filter = Builders<Reservas>
                .Filter
                .Eq(s => s.Id, reserva.Id);

            await collection.ReplaceOneAsync(filter, reserva);
        }


        
        
    }

}