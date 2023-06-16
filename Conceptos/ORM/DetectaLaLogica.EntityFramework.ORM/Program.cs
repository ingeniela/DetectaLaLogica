using DetectaLaLogica.EntityFramework.ORM.Core;
using DetectaLaLogica.EntityFramework.ORM.DataAccess;
using System;
using System.Linq;

namespace DetectaLaLogica.EntityFramework.ORM
{
    public class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext();

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add a new client");
                Console.WriteLine("2. View all clients");
                Console.WriteLine("3. Update a client");
                Console.WriteLine("4. Delete a client");
                Console.WriteLine("5. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddClient(db);
                            break;
                        case 2:
                            ViewAllClients(db);
                            break;
                        case 3:
                            UpdateClient(db);
                            break;
                        case 4:
                            DeleteClient(db);
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        static void AddClient(MyDbContext db)
        {
            Console.WriteLine("\nAdding a new client...");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            var newClient = new Client
            {
                Name = name,
                Email = email
            };

            db.Clients.Add(newClient);
            db.SaveChanges();

            Console.WriteLine($"Added client: {newClient.Name} ({newClient.Email})");
        }

        static void ViewAllClients(MyDbContext db)
        {
            Console.WriteLine("\nAll clients in the database:");

            foreach (var client in db.Clients)
            {
                Console.WriteLine($"{client.Id}. {client.Name} ({client.Email})");
            }
        }

        static void UpdateClient(MyDbContext db)
        {
            Console.WriteLine("\nUpdating a client...");

            Console.Write("Enter the ID of the client you want to update: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var client = db.Clients.Find(id);
                if (client == null)
                {
                    Console.WriteLine("Client not found. Please try again.");
                    return;
                }

                Console.WriteLine($"Updating client: {client.Name} ({client.Email})");

                Console.Write("New name: ");
                string name = Console.ReadLine();
                Console.Write("New email: ");
                string email = Console.ReadLine();

                client.Name = name;
                client.Email = email;
                db.SaveChanges();
                
                Console.WriteLine($"Updated client: {client.Name} ({client.Email})");
            }
            else
            {
                Console.WriteLine("Invalid client ID. Please try again.");
            }
        }

        static void DeleteClient(MyDbContext db)
        {
            Console.WriteLine("\nDeleting a client...");

            Console.Write("Enter the ID of the client you want to delete: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var client = db.Clients.Find(id);
                if (client == null)
                {
                    Console.WriteLine("Client not found. Please try again.");
                    return;
                }

                db.Clients.Remove(client);
                db.SaveChanges();
                Console.WriteLine($"Deleted client: {client.Name} ({client.Email})");
            }
            else
            {
                Console.WriteLine("Invalid client ID. Please try again.");
            }
        }
    }
}
