using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonalDoctors.Models
{
    public class DoctorContext : DbContext
    {
        public DbSet<Patient> patients { get; set; }
        //public DbSet<Order> orders { get; set; }

        public DoctorContext(DbContextOptions<DoctorContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
