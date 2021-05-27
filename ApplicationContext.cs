using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MIAPO_UP
{
    class ApplicationContext : DbContext
    {

        public DbSet<Employer> Employer { get; set; }
        public DbSet<Users> Users { get; set; }

        public DbSet<Position> Position { get; set; }
        public DbSet<Shift> Shift { get; set; }

        public DbSet<Service_car> Service_car { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }
    }
}
