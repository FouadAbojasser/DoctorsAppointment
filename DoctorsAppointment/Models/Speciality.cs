namespace DoctorsAppointment.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public List<Doctor> Doctors { get; } = [];
    }
}
