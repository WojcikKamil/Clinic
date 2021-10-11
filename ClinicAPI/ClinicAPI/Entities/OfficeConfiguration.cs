using ClinicAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Entities
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasData(
              new Office
              {
                  Id = 1,
                  Name = "Gynecology office",
                  Floor = 1,
              },
              new Office
              {
                  Id = 2,
                  Name = "Surgeon office",
                  Floor = 1,
              },
              new Office
              {
                  Id = 3,
                  Name = "Psychiatry office",
                  Floor = 1,
              },
               new Office
               {
                   Id = 4,
                   Name = "Office",
                   Floor = 1,
               },
                new Office
                {
                    Id = 5,
                    Name = "Office",
                    Floor = 1,
                },
                 new Office
                 {
                     Id = 6,
                     Name = "Office",
                     Floor = 1,
                 },
                  new Office
                  {
                      Id = 7,
                      Name = "Office",
                      Floor = 1,
                  }
              );
        }
    }
}
