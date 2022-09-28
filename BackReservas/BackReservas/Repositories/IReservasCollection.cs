using BackReservas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReservas.Repositories
{
   public interface IReservasCollection
    {

        Task InsertReservas(Reservas reserva);

        Task UpdateReservas(Reservas reserva);

        Task DeleteReservas(string id);

        Task<List<Reservas>> GetAllReservas();

        Task<Reservas> GetReservaById(string id);
    }
}
