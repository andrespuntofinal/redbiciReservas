using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReservas.Models
{
    public class Reservas
    {

        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string FechaReserva { get; set; }

        public string UserReserva { get; set; }

        [BsonElement("IdBicicleta"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string IdBicicleta { get; set; }

        public int EstadoReserva { get; set; }

        public string FechaDevolucion { get; set; }

    }
}
