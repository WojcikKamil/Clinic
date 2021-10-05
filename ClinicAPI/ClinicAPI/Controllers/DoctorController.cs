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
    public class DoctorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DoctorController> _logger;
        private readonly IMapper _mapper;


        public DoctorController(IUnitOfWork unitOfWork, ILogger<DoctorController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetDoctors([FromQuery] RequestParams requestParams)
        {
            
                var doctors = await _unitOfWork.Doctors.GetPagedList(requestParams);
                var results = _mapper.Map<IList<DoctorDTO>>(doctors);
                return Ok(results);
            
        }

        [Authorize]
        [HttpGet("{id:int}", Name = "GetDoctor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetDoctor(int id)
        {
           
                var doctor = await _unitOfWork.Doctors.Get(q => q.Id == id);
                var result = _mapper.Map<DoctorDTO>(doctor);
                return Ok(result);
            
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddDoctor([FromBody] AddDoctorDTO doctorDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(AddDoctor)}");
                return BadRequest(ModelState);
            }
            try
            {
                var doctor = _mapper.Map<Doctor>(doctorDTO);
                await _unitOfWork.Doctors.Insert(doctor);
                await _unitOfWork.Save();

                return CreatedAtRoute("GetDoctor", new { id = doctor.Id }, doctor);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(AddDoctor)}");
                return StatusCode(500, "Internal Server Error. Please try again later");
            }
        }

        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDoctor(int id, [FromBody] UpdateDoctorDTO doctorDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateDoctor)}");
                return BadRequest(ModelState);
            }

            try
            {
                var doctor = await _unitOfWork.Doctors.Get(q => q.Id == id);
                if(doctor == null)
                {
                    _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateDoctor)}");
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(doctorDTO, doctor);
                _unitOfWork.Doctors.Update(doctor);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(UpdateDoctor)}");
                return StatusCode(500, "Internal Server Error. Please try again later");
            }
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteDoctor)}");
                return BadRequest();
            }

           
                var doctor = await _unitOfWork.Doctors.Get(q => q.Id == id);
                if (doctor == null)
                {
                    _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteDoctor)}");
                    return BadRequest("Submitted data is invalid");
                }
                await _unitOfWork.Doctors.Delete(id);
                await _unitOfWork.Save();

                return NoContent();

        }
        
    }
}