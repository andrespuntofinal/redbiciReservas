using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReservas.Models
{

    [Serializable]
    public class CReservas
    {

        

        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        
        public string IdReserva { get; set; }

        [BsonElement("FechaReserva"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string FechaReserva { get; set; }

        [BsonElement("UserReserva"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string UserReserva { get; set; }

        [BsonElement("IdBicicleta"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string IdBicicleta { get; set; }

        [BsonElement("EstadoReserva"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]

        public int EstadoReserva { get; set; }

        [BsonElement("FechaDevolucion"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string FechaDevolucion { get; set; }

    }
}
