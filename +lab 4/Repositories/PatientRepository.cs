using HospitalAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Repositories
{
    public class PatientRepository : DbContext
    {
        public PatientRepository(DbContextOptions<PatientRepository> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }

    }
}
