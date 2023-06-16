using DetectaLaLogica.EntityFramework.ORM.Core;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectaLaLogica.EntityFramework.ORM.DataAccess
{
    public class MyDbContext : DbContext
    {
        internal readonly string connectionString = "server=localhost;port=3306;database=dbclients;uid=root;pwd=Danyg06;";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(ServerVersion.AutoDetect(connectionString)));
        }

        public DbSet<Client> Clients { get; set; }
    }
}
