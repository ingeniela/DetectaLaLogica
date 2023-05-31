using Class.DependencyInjection.Classes;
using Class.DependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.DependencyInjection.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void SaveTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public Ticket GetTicketById(int id)
        {
            return tickets.Find(ticket => ticket.Id == id);
        }

        public void UpdateTicket(Ticket updatedTicket)
        {
            int index = tickets.FindIndex(ticket => ticket.Id == updatedTicket.Id);
            if (index != -1)
            {
                tickets[index] = updatedTicket;
            }
            else
            {
                throw new InvalidOperationException("Ticket not found");
            }
        }

        public void DeleteTicket(int id)
        {
            int index = tickets.FindIndex(ticket => ticket.Id == id);
            if (index != -1)
            {
                tickets.RemoveAt(index);
            }
            else
            {
                throw new InvalidOperationException("Ticket not found");
            }
        }
    }
}
