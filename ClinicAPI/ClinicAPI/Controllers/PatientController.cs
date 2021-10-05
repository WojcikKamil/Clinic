using AutoMapper;
using ClinicAPI.Data;
using ClinicAPI.IRepository;
using ClinicAPI.Models;
using Microsoft.AspNetCore.Authorization;
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
            
                var patients = await _unitOfWork.Patients.GetALL();
                var results = _mapper.Map<IList<PatientDTO>>(patients);
                return Ok(patients);
        }

        [HttpGet("CheckDoctorByPatientID{id:int}")]
        public async Task<IActionResult> GetPatientsDoctor(int id)
        {
            
                var patient = await _unitOfWork.Patients.Get(q => q.Id == id, new List<string> {"Doctor"});
                var result = _mapper.Map<PatientDTO>(patient);
                return Ok(result);
            
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddPatient([FromBody] AddPatientDTO patientDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(AddPatient)}");
                return BadRequest(ModelState);
            }

            var patient = _mapper.Map<Patient>(patientDTO);
            await _unitOfWork.Patients.Insert(patient);
            await _unitOfWork.Save();

            return CreatedAtRoute(new { id = patient.Id }, patient);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePatient(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePatient)}");
                return BadRequest();
            }


            var patient = await _unitOfWork.Patients.Get(q => q.Id == id);
            if (patient == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePatient)}");
                return BadRequest("Submitted data is invalid");
            }
            await _unitOfWork.Patients.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
}
