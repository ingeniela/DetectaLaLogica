using Class.DependencyInjection.Classes;
using Class.DependencyInjection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.DependencyInjection.Services
{
    class TicketService
    {

        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        private void PrintTicket(Ticket ticket)
        {
            _ticketRepository.GetTickets();

            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|                                                  |");
            Console.WriteLine("|                   TICKET                         |");
            Console.WriteLine("|                                                  |");
            Console.WriteLine("   Id: " + ticket.Id);
            Console.WriteLine("   Name: " + ticket.Name);
            Console.WriteLine("|  Issued At: " + ticket.IssuedAt + "                  |");
            Console.WriteLine("|  Ticket Number: " + ticket.TicketNumber + "                            |");
            Console.WriteLine("|                                                  |");
            Console.WriteLine("+--------------------------------------------------+");
        }

        public string GenerateTicket(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name parameter cannot be null or empty", nameof(name));
            }

            Random rnd = new Random();
            int ticketNumber = rnd.Next(10000, 99999);
            int ticketId = rnd.Next(1000, 9999);
            DateTime dateNow = DateTime.Now;

            Ticket newTicket = new Ticket();
            newTicket.Id = ticketId;
            newTicket.Name = name;
            newTicket.IssuedAt = dateNow;
            newTicket.TicketNumber = ticketNumber;

            try
            {
                _ticketRepository.SaveTicket(newTicket);
                PrintTicket(newTicket);

                return "Ticket saved successfully";
            }
            catch (InvalidOperationException ex)
            {
                return ex.Message;
            }
        }

        public string GetTicket(int id)
        {
            try
            {
                Ticket getTicket = _ticketRepository.GetTicketById(id);
                if (getTicket == null)
                {
                    throw new InvalidOperationException("Ticket not found");
                }

                PrintTicket(getTicket);
                return "Done";
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Failed to get ticket", ex);
            }
        }

        public string UpdateTicket(Ticket updatedTicket)
        {
            try
            {
                _ticketRepository.UpdateTicket(updatedTicket);
                return "Ticket updated successfully";
            }
            catch (InvalidOperationException ex)
            {
                return ex.Message;
            }
        }

        public string DeleteTicket(int id)
        {
            try
            {
                _ticketRepository.DeleteTicket(id);
                return "Ticket deleted successfully";
            }
            catch (InvalidOperationException ex)
            {
                return ex.Message;
            }
        }
    }
}
