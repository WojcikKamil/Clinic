using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Models
{
    public class CreateDoctorDTO
    {
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Too long Name ;D")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Too long Surname ;D")]
        public string Surname { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "The speciality is too long")]
        public string Speciality { get; set; }

        public int OfficeId { get; set; }
    }

    public class DoctorDTO : CreateDoctorDTO
    {
        public int Id { get; set; }
        public IList<PatientDTO> Patients { get; set; }
    }
}
