namespace DoctorsAppointment.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateOnly Year { get; set; }
        public List<Doctor> Doctors { get; } = [];

    }
}
