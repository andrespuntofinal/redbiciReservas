using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackReservas.Models;

using static BackReservas.Models.CBicicletas;
using MongoDB.Bson;
using MongoDB.Driver;
using BackReservas.Repositories;

namespace BackReservas.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DisponibilidadController : Controller
    {
       
        internal MongoDBRepository _repository = new MongoDBRepository();
       

        [HttpGet]
        public ActionResult<List<CReservas>> Get()
        {

            //collection = _repository.db.GetCollection<Reservas>("Reservas");
            var BicicleCollection = _repository.db.GetCollection<CBicicletas>("Bicicletas");
            var ReservaCollection = _repository.db.GetCollection<CReservas>("Reservas");

            var result = BicicleCollection.Aggregate()
                .Lookup<CBicicletas, CReservas, BicicletasLookedUp>(ReservaCollection, a => a.IdBicicleta, a => a.IdBicicleta, a => a.CReservasList)
                .ToEnumerable()
                .SelectMany(a => a.CReservasList.Select(b => new
                {
                    a.IdBicicleta,
                    a.Modelo,
                    a.Color,
                    a.Latitud,
                    a.Longitud,
                    a.UserPropietario,
                    b.EstadoReserva,
                    b.FechaDevolucion,
                    b.FechaReserva,
                    b.UserReserva


                }))

                .ToList();

            return Ok(result);
        }


    }
}
