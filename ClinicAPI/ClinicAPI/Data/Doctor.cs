using ClinicAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Data
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }

        [ForeignKey(nameof(Office))]
        public int OfficeId { get; set; }
        public Office Office { get; set; }

        public virtual IList<Patient> Patients { get; set; }
    }
}
