namespace DoctorsAppointment.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPhone { get; set; }
        public DateOnly PatientDofB {  get; set; }
        public int Age { get; set; }
        public DateOnly AppoDate { get; set; }
        public TimeOnly AppoTime { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

    }
}
