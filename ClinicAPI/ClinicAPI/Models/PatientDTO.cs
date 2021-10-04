using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Models
{
    public class CreatePatientDTO
    {
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Too long Name ;D")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Too long Surname ;D")]
        public string Surname { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Too long Adress ;D")]
        public string Adress { get; set; }
    }
    public class PatientDTO : CreatePatientDTO
    {
        public int Id { get; set; }
        public DoctorDTO Doctor { get; set; }
       
    }
}
