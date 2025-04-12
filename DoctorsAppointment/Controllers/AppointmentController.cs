using DoctorsAppointment.Data;
using DoctorsAppointment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorsAppointment.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _dBcontext = new ();
        public IActionResult Index(int DoctorId, int RecordsPerPage=5, int Page =1)
        {
            IQueryable<Appointment> appointments = _dBcontext.Appointments
                .Include(d => d.Doctor)
                .Skip((Page - 1) * RecordsPerPage)
                .Take(RecordsPerPage);
   
            ViewBag.Page = Page;
            ViewBag.RecordsPerPage = RecordsPerPage;
            ViewBag.TotalPages = (int)(Math.Ceiling((double)_dBcontext.Appointments.Count() / RecordsPerPage)) ;

            return View(appointments);
        }

      

        public IActionResult AddAppointment(Appointment appointment, int DoctorId)
        {
            _dBcontext.Add(new Appointment
            {
                PatientName = appointment.PatientName,
                PatientDofB = appointment.PatientDofB,
                PatientEmail = appointment.PatientEmail,
                PatientPhone = appointment.PatientPhone,
                Age = DateTime.Now.Year - appointment.PatientDofB.Year,
                AppoDate = appointment.AppoDate,
                AppoTime = appointment.AppoTime,
                DoctorId = DoctorId
            });
            _dBcontext.SaveChanges();

            //return RedirectToAction("DoctorsList", "Doctors");
            return RedirectToAction("Index");
        }
    }
}
