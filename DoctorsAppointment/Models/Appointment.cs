namespace DoctorsAppointment.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PationtName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public DateOnly UpdatedDate { get; set; }
        public TimeOnly CreatedDate { get; set; }
        public string Disease { get; set; }

    }
}
