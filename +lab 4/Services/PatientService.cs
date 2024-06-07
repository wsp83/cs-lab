using HospitalAPI.Dtos;
using HospitalAPI.Models;
using HospitalAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Services
{
    public class PatientService
    {
        private readonly PatientRepository patientRepository;

        public PatientService(PatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public Patient DtoToObject(PatientDto patientDto)
        {
            return new Patient
            {
                FullName = patientDto.FullName,
                Oib = patientDto.Oib,
                Mbo = patientDto.Mbo,
                Sex = patientDto.Sex,
                Dob = patientDto.Dob,
                Diagnosis = patientDto.Diagnosis,
                HasPremiumInsurance = patientDto.HasPremiumInsurance,
                IsCheckedIn = patientDto.IsCheckedIn
            };
        }

        public void AddPatient(Patient patient)
        {
            if (patient is not null)
            {
                patientRepository.Patients.Add(patient);
                patientRepository.SaveChanges();
            }
        }

        public async Task<ActionResult<List<Patient>>> GetAllPatients()
        {
            return await patientRepository.Patients.ToListAsync();
        }

        public async Task<ActionResult<Patient>> GetPatientById(int id)
        {
            return await patientRepository.Patients.FindAsync(id);
        }

        public void UpdatePatient(Patient patient)
        {
            if (patient is not null)
            {
                patientRepository.Patients.Update(patient);
                patientRepository.SaveChanges();
            }
        }
    }
}
