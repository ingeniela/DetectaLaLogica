using Class.DependencyInjection.Classes;
using Class.DependencyInjection.Repositories;
using Class.DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;

class FootballStadium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the DI container
            var serviceProvider = new ServiceCollection()
                .AddTransient<ITicketRepository, TicketRepository>()
                .AddTransient<TicketService>()
                .BuildServiceProvider();

            // Resolve the TicketGenerator instance from the DI container
            var _ticket = serviceProvider.GetService<TicketService>();
            var _ticketRepository = serviceProvider.GetService<ITicketRepository>();

            // Ask for a name
            Console.WriteLine("Welcome to the Football Stadium! what is your name? ");
            string name = Console.ReadLine();

            // Generate aticket
            string generatedTicket = _ticket.GenerateTicket(name);
            Console.WriteLine(generatedTicket);

            // Say goodbye
            Console.ReadKey();
        }
    }
}