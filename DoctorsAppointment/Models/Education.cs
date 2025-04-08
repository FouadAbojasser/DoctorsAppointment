namespace DoctorsAppointment.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string University { get; set; }
        public string Specialization { get; set; }
        public DateOnly Year { get; set; }
        public List<Doctor> Doctors { get; } = [];

    }
}
