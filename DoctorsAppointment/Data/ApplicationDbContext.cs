using DoctorsAppointment.Models;
using Microsoft.EntityFrameworkCore;
namespace DoctorsAppointment.Data

{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DoctorsDB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            // Add new configurations for the new columns
            modelBuilder.Entity<Doctor>()
             .Property(p => p.Introduction)
             .HasColumnName("Introduction") // Custom column name
             .HasMaxLength(500) // Maximum length
             .IsRequired(false) // NOT NULL
             .HasDefaultValue("Default Introduction"); // Default value

            modelBuilder.Entity<Doctor>()
                .Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(500)
                .IsRequired(true)
                .HasDefaultValue("doctor@hospital.net");


            modelBuilder.Entity<Doctor>()
                .Property(p => p.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasMaxLength(20)
                .IsRequired(true)
                .HasDefaultValue("+201151917913");


            modelBuilder.Entity<Doctor>()
                .Property(p => p.DateOfBirth)
                .HasColumnName("DateOfBirth")
                .HasColumnType("Date")
                .IsRequired(true)
                .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Doctor>()
                .Property(p => p.Gender)
                .HasColumnName("Gender")
                .HasMaxLength(10)
                .IsRequired(false);



            modelBuilder.Entity<Doctor>()
                .Property(p => p.Address)
                .HasColumnName("Address")
                .HasMaxLength(200)
                .IsRequired(false);
               


            modelBuilder.Entity<Doctor>()
                .Property(p => p.NationalID)
                .HasColumnName("NationalID")
                .HasMaxLength(20)
                .IsRequired(true)
                .HasDefaultValue("12345678910");


            modelBuilder.Entity<Doctor>()
                .Property(p => p.RegistrationNumber)
                .HasColumnName("RegistrationNumber")
                .HasMaxLength(20)
                .IsRequired(true)
                .HasDefaultValue("9876543210");


            modelBuilder.Entity<Doctor>()
                .Property(p => p.DoctorType)
                .HasColumnName ("DoctorType")
                .HasMaxLength (20)
                .IsRequired(true)
                .HasDefaultValue("Cardiology");

    
        }

    }


}
