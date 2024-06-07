using Microsoft.EntityFrameworkCore;
using lab6.Data;
using WebApp.Models;

namespace WebApp.Services
{
    public class PatientService : IPatientService
    {
        private readonly ApplicationDbContext _context;

        public PatientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync(string src, string sortOrder)
        {
            var patients = from p in _context.Patients select p;

            if (!String.IsNullOrEmpty(src))
            {
                patients = patients.Where(p =>
                    p.FullName.Contains(src) || p.Oib.Contains(src) || p.Mbo.Contains(src) || p.AdmissionDate.ToString().Contains(src) || p.DischargeDate.ToString().Contains(src));
            }

            patients = sortOrder switch
            {
                "namedesc" => patients.OrderByDescending(p => p.FullName),
                "admission" => patients.OrderBy(p => p.AdmissionDate),
                "admissiondesc" => patients.OrderByDescending(p => p.AdmissionDate),
                "discharge" => patients.OrderBy(p => p.DischargeDate),
                "dischargedesc" => patients.OrderByDescending(p => p.DischargeDate),
                "oib" => patients.OrderBy(p => p.Oib),
                "oibdesc" => patients.OrderByDescending(p => p.Oib),
                "mbo" => patients.OrderBy(p => p.Mbo),
                "mbodesc" => patients.OrderByDescending(p=>p.Mbo),
                _ => patients.OrderBy(p=>p.FullName),
            };
          
            return await patients.ToListAsync();
        }

        public async Task DeletePatientAsync(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DischargePatientAsync(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                patient.IsCheckedIn = true;
                patient.DischargeDate = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task AddPatientAsync(Patient patient)
        {
            IsValid(patient);
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            IsValid(patient);
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
        }

        private void IsValid(Patient patient)
        {
            if(string.IsNullOrWhiteSpace(patient.Oib) || !patient.Oib.All(char.IsDigit) || patient.Oib.Length!=11)
            {
                throw new ArgumentException("Invalid OIB");
            }

            if(string.IsNullOrWhiteSpace(patient.Mbo) || !patient.Mbo.All(char.IsDigit)|| patient.Mbo.Length!=9)
            {
                throw new ArgumentException("Invalid MBO");
            }

            if(string.IsNullOrWhiteSpace(patient.FullName) || !patient.FullName.Contains(" ") || patient.FullName.Split(' ').Length<2 || patient.FullName.Any(c=> !char.IsLetter(c) && !char.IsWhiteSpace(c))){
                throw new ArgumentException("Invalid name");
            }
            if (patient.Dob>DateTime.Now)
            {
                throw new ArgumentException("Invalid date");
            }

            if(patient.AdmissionDate > patient.DischargeDate)
            {
                throw new ArgumentException("Invalid date");
            }
        }
    }
}
