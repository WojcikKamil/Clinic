using ClinicAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Entities
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
                new Doctor
                  {
                      Id = 1,
                      Name = "Adelaida",
                      Surname = "Timko",
                      Email = "Adelaida@Timko.com",
                      Speciality = "Gynecology",
                      OfficeId = 1,

                  },
                new Doctor
                {
                    Id = 2,
                    Name = "Zehang",
                    Surname = "Wang",
                    Email = "Zehang@Wang.com",
                    Speciality = "Surgery",
                    OfficeId = 2,
                },
                new Doctor
                {
                    Id = 3,
                    Name = "Sasha",
                    Surname = "Steklovata",
                    Email = "Sasha@Steklovata.com",
                    Speciality = "Psychology",
                    OfficeId = 3,
                }
                );
        }
    }
}
