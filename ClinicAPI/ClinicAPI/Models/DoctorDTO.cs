using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Models
{
    public class AddDoctorDTO
    {
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Too long Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Too long Surname")]
        public string Surname { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Too long Adress Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "The speciality is too long")]
        public string Speciality { get; set; }

        public int OfficeId { get; set; }
       
    }

    public class DoctorDTO : AddDoctorDTO
    {
        public int Id { get; set; }
        public IList<PatientDTO> Patients { get; set; }
    }

    public class UpdateDoctorDTO : AddDoctorDTO
    {

    }
}
