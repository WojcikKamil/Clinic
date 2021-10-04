using AutoMapper;
using ClinicAPI.IRepository;
using ClinicAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<PatientController> _logger;
        private readonly IMapper _mapper;

        public PatientController(IUnitOfWork unitOfWork, ILogger<PatientController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            try
            {
                var patients = await _unitOfWork.Patients.GetALL();
                var results = _mapper.Map<IList<PatientDTO>>(patients);
                return Ok(patients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetPatients)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }

        [HttpGet("CheckDoctorByPatientID{id:int}")]
        public async Task<IActionResult> GetPatients(int id)
        {
            try
            {
                var patient = await _unitOfWork.Patients.Get(q => q.Id == id, new List<string> {"Doctor" });
                var result = _mapper.Map<PatientDTO>(patient);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetPatients)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }
    }
}
