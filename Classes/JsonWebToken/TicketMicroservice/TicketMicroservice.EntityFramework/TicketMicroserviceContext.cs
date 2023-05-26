using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMicroservice.EntityFramework
{
    public class TicketMicroserviceContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public TicketMicroserviceContext(DbContextOptions<TicketMicroserviceContext> options) : base(options)
        {

        }
    }
}
