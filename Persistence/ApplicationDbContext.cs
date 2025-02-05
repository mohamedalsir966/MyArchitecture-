using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Domain;

namespace Persistence
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientVaccin> PatientVaccin { get; set; }
        public DbSet<Vaccin> Vaccin { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


        //}

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

    }

}
