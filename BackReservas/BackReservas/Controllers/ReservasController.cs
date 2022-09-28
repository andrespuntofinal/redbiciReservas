using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackReservas.Repositories;
using Microsoft.AspNetCore.Mvc;
using BackReservas.Models;

using static BackReservas.Models.CBicicletas;
using MongoDB.Bson;
using MongoDB.Driver;


namespace BackReservas.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : Controller
    {
        
       
        private IReservasCollection db = new ReservasCollection();

        [HttpGet]
        public async Task<IActionResult> GetAllReservas()
        {

            try
            {

                return Ok(await db.GetAllReservas());

            }

            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllReservasDetails(string id)
        {

            return Ok(await db.GetReservaById(id));


        }


        [HttpPost]

        public async Task<IActionResult> CreateReservas([FromBody] Reservas reserva)
        {
            if (reserva == null)
                return BadRequest();

            if (reserva.IdBicicleta == "")
            {

                ModelState.AddModelError("Id Reserva", "El id no debe ir vacío");


            }

            await db.InsertReservas(reserva);


            return Created("Created", true);



        }


        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateReservas([FromBody] Reservas reservas, string id)
        {
            if (reservas == null)
                return BadRequest();

            if (reservas.IdBicicleta == "")
            {

                ModelState.AddModelError("Id Bici", "El id no debe ir vacío");


            }

            //reservas.Id = new MongoDB.Bson.ObjectId(id);
            await db.UpdateReservas(reservas);


            return Created("Created", true);



        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservas(string id)
        {

            await db.DeleteReservas(id);

            return NoContent();
        }


    }
}
