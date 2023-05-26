using Class.DependencyInjection.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.DependencyInjection.Repositories
{
    public interface ITicketRepository
    {
        void SaveTicket(Ticket ticket);
        List<Ticket> GetTickets();
        Ticket GetTicketById(int id);
        void UpdateTicket(Ticket updatedTicket);
        void DeleteTicket(int id);
    }
}
