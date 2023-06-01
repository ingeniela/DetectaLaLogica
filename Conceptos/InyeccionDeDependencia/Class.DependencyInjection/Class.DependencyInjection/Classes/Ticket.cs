using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.DependencyInjection.Classes
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TicketNumber { get; set; }
        public DateTime IssuedAt { get; set; }
    }
}
