using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using WebAppHospital.Models;

namespace WebAppHospital.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbOptions) : base(dbOptions)
        {
            
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
