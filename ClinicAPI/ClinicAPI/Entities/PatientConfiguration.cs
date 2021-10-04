using ClinicAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Entities
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
                new Patient
                {
                    Id = 1,
                    Name = "Natasha",
                    Surname = "Sasha",
                    Adress = "Lviv",
                    DoctorId = 1,
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
        }
    }
}
