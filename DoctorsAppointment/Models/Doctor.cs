using Azure;

namespace DoctorsAppointment.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Img { get; set; }
        public string Introduction { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string NationalID { get; set; }
        public string RegistrationNumber { get; set; }
        public string DoctorType { get; set; }
        public List<Membership> Memberships { get; } = [];
        public List<Education> Educations { get; } = [];
        public List<Speciality> Specialities { get; } = [];
    }
}
