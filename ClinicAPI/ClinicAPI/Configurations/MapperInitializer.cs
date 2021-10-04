using AutoMapper;
using ClinicAPI.Data;
using ClinicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Doctor, DoctorDTO>().ReverseMap();
            CreateMap<Doctor, CreateDoctorDTO>().ReverseMap();
            CreateMap<Patient, PatientDTO>().ReverseMap();
            CreateMap<Patient, CreatePatientDTO>().ReverseMap();
        }
    }
}
