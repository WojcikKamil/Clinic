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

        public async Task<IActionResult> GetDoctors()
        {
            try
            {
                var doctors = await _unitOfWork.Doctors.GetALL();
                var results = _mapper.Map<IList<DoctorDTO>>(doctors);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetDoctors)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetDoctor(int id)
        {
            try
            {
                var doctor = await _unitOfWork.Doctors.Get(q => q.Id == id);
                var result = _mapper.Map<DoctorDTO>(doctor);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetDoctors)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }
    }
}