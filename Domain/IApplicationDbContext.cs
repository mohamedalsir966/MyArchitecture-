using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Domain
{
    public interface IApplicationDbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientVaccin> PatientVaccin { get; set; }
        public DbSet<Vaccin> Vaccin { get; set; }
        Task<int> SaveChangesAsync();
    }
}
