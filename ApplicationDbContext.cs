using doctor.Model;
using Microsoft.EntityFrameworkCore;

namespace doctor
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }

        public DbSet<Visit> Visits { get; set; }
        public DbSet<Pacient> Pacients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
