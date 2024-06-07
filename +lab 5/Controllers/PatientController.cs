using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppHospital.Data;
using WebAppHospital.Models;

namespace WebAppHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly DataContext context;

        public PatientController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await context.Patients.ToListAsync();
            return Ok(patients);
        }

        [HttpGet("{oib}")]
        public async Task<IActionResult> GetPatient(long oib)
        {
            var patient = await context.Patients.Where(p => p.Oib == oib).FirstOrDefaultAsync();
            return (patient != null) ? Ok(patient) : NotFound();
        }

        [HttpPost("new-patient")]
        public async Task<IActionResult> AddPatient(long oib, long mbo, string fullName, DateTime dob, char sex, string diagnosis, bool premiumInsurance, bool checkedIn)
        {
            Patient patient = new Patient(oib, mbo, fullName, dob, sex, diagnosis, premiumInsurance, checkedIn);
            if (patient.IsValid())
            {
                var existing = await context.Patients.Where(p => p.Oib == oib).FirstOrDefaultAsync();
                if (existing == null) 
                {
                    context.Patients.Add(patient);
                    await context.SaveChangesAsync();
                    return Ok(patient);
                }
                else
                    return BadRequest("Patient already existing.")
            }
            else
                return BadRequest("Invalid patient info.");
        }

        [HttpGet("checked/{checkedIn}")]
        public async Task<IActionResult> GetPatientsByCheckedIn(bool checkedIn)
        {
            var patients = await context.Patients.Where(p => p.CheckedIn == checkedIn).ToListAsync();
            return Ok(patients);
        }

        [HttpPut("modify-diagnosis/{oib}")]
        public async Task<IActionResult> ChangeDiagnosis(long oib, string diagnosis)
        {
            var patient = await context.Patients.Where(p => p.Oib == oib).FirstOrDefaultAsync();
            if(patient != null)
            {
                patient.Diagnosis = diagnosis;
                await context.SaveChangesAsync();
                return Ok(patient);
            }
            else
                return NotFound();
        }

        [HttpPut("modify-status/{oib}")]
        public async Task<IActionResult> ChangeCheckedIn(long oib)
        {
            var patient = await context.Patients.Where(p => p.Oib == oib).FirstOrDefaultAsync();
            if (patient != null)
            {
                patient.CheckedIn = !patient.CheckedIn;
                await context.SaveChangesAsync();
                return Ok(patient);
            }
            else
                return NotFound();
        }

        [HttpGet("diagnosis/{oib}")]
        public async Task<IActionResult> GetPatientDiagnosis(long oib)
        {
            var patient = await context.Patients.Where(p => p.Oib == oib).FirstOrDefaultAsync();
            return (patient != null) ? Ok(patient.Diagnosis) : NotFound();
        }

        [HttpGet("insurance/{oib}")]
        public async Task<IActionResult> GetPatientInsuranceType(long oib)
        {
            var patient = await context.Patients.Where(p => p.Oib == oib).FirstOrDefaultAsync();
            if(patient != null)
                return (patient.PremiumInsurance) ? Ok("Premium Insurance active") : Ok("Mandatory insurance");
            else
                return NotFound();
        }

        [HttpDelete("{oib}")]
        public async Task<IActionResult> DeletePatient(long oib)
        {
            var patient = await context.Patients.Where(p => p.Oib == oib).FirstOrDefaultAsync();
            if (patient != null)
            {
                context.Patients.Remove(patient);
                await context.SaveChangesAsync();
                return NoContent();
            }
            else
                return NotFound();
        }
    }
}
