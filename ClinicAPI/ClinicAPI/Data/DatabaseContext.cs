using ClinicAPI.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            
            builder.ApplyConfiguration(new DoctorConfiguration());
            builder.ApplyConfiguration(new PatientConfiguration());
            builder.ApplyConfiguration(new OfficeConfiguration());
            // Added Role 
            builder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
