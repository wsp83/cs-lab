using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace lab6.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
    }
}
