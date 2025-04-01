using DoctorsAppointment.Models;
using Microsoft.EntityFrameworkCore;
namespace DoctorsAppointment.Data

{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DoctorsAppointment;Integrated Security=True;TrustServerCertificate=True");
        }

    }
}
