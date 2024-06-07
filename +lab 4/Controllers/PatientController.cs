using HospitalAPI.Dtos;
using HospitalAPI.Models;
using HospitalAPI.Repositories;
using HospitalAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientService patientService;

        public PatientController(PatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpPost]
        public IActionResult AddPatient([FromBody] PatientDto patientDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var patient = patientService.DtoToObject(patientDto);
            patientService.AddPatient(patient);
            return Ok(patient);
        }

        [HttpGet]
        public async Task<ActionResult<List<Patient>>> GetAllPatients()
        {
            var patients = await patientService.GetAllPatients();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = patientService.GetPatientById(id);
            return Ok(patient.Result.Value);
        }

        [HttpPut("{id}")]
        public ActionResult ModifyPatient(int id, [FromBody] PatientModifyDto patientDto)
        {
            var result = patientService.GetPatientById(id);
            var patient = result.Result.Value;
            if (patient == null)
                return NotFound("No such patient.");
            else
            {
                patient.IsCheckedIn = patientDto.IsCheckedIn;
                patient.HasPremiumInsurance = patientDto.HasPremiumInsurance;
                patient.Diagnosis = patientDto.Diagnosis;

                patientService.UpdatePatient(patient);
                return Ok(patient);
            }
            

        }

    }
}
