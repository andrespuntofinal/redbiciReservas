using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReservas.Models
{

    [Serializable]
    public class CBicicletas
    {



        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string IdBicicleta { get; set; }

        [BsonElement("Color"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string Color { get; set; }

        [BsonElement("Modelo"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string Modelo { get; set; }

        [BsonElement("Latitud"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]

        public decimal Latitud { get; set; }

        [BsonElement("Longitud"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]

        public decimal Longitud { get; set; }

        [BsonElement("UserPropietario"), BsonRepresentation(MongoDB.Bson.BsonType.String)]

        public string UserPropietario { get; set; }

        public class BicicletasLookedUp : CBicicletas

        {

            public List<CReservas> CReservasList { get; set; }

        }

    }
}
