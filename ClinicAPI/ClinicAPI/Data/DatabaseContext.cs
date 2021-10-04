using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Patient>().HasData(
                new Patient
                {
                    Id = 1,
                    Name = "Natasha",
                    Surname = "Sasha",
                    Adress = "Lviv",
                    DoctorId =1,
                },
                new Patient
                {
                    Id = 2,
                    Name = "Katyusha",
                    Surname = "Miroshnychenko",
                    Adress = "Kiev",
                    DoctorId = 1,
                },
                new Patient
                {
                    Id = 3,
                    Name = "Sasha",
                    Surname = "Kovt",
                    Adress = "Zimna Voda",
                    DoctorId = 1,
                },
                new Patient
                {
                    Id = 4,
                    Name = "Anastasia",
                    Surname = "Shutova",
                    Adress = "Minsk",
                    DoctorId = 2,
                },
                new Patient
                {
                    Id = 5,
                    Name = "Anja",
                    Surname = "Melchenko",
                    Adress = "Kharkv",
                    DoctorId = 3,
                }
                );

            builder.Entity<Office>().HasData(
                new Office
                {
                    Id=1,
                    Name = "Gynecology office",
                    Floor = 1,
                },
                new Office
                {
                    Id=2,
                    Name = "Surgeon office",
                    Floor = 1,
                },
                new Office
                {
                    Id=3,
                    Name = "Psychiatry office",
                    Floor = 1,
                }
                );
            builder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Adelaida",
                    Surname = "Timko",
                    Speciality = "Gynecology",
                    OfficeId = 1,

                },
                new Doctor
                {
                    Id = 2,
                    Name = "Zehang",
                    Surname = "Wang",
                    Speciality = "Surgery",
                    OfficeId = 2,
                },
                new Doctor
                {
                    Id = 3,
                    Name = "Sasha",
                    Surname = "Steklovata",
                    Speciality = "Psychology",
                    OfficeId = 3,
                }
                );
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
