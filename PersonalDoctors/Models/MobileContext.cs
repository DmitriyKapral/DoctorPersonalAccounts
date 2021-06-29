using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonalDoctors.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> phones { get; set; }
        public DbSet<Order> orders { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
