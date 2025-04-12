using AspNetCoreGeneratedDocument;
using DoctorsAppointment.Data;
using DoctorsAppointment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorsAppointment.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context = new ();
        public IActionResult DoctorsList(string doctor_name, int specialization_id, string gender_name, string location)
        {
           
            IQueryable<Doctor> doctors = _context.Doctors.Include(d => d.Specialities);

            var distinctSpecialities = _context.Specialities.Distinct().OrderBy(e=>e.Title);
            ViewData["specialities"] = distinctSpecialities.ToList();

           
            if (!string.IsNullOrEmpty(doctor_name))
            {
                doctors = doctors.Where(d => d.Name.Contains(doctor_name));
                ViewBag.DoctorName = doctor_name;
            }

            if (specialization_id > 0 && specialization_id <= distinctSpecialities.Count())
            {
                doctors = doctors.Where(d => d.Specialities.Any(s => s.Id == specialization_id));
                ViewBag.SpecializationId = specialization_id;
            }

            if (!string.IsNullOrEmpty(gender_name))
            {
                doctors = doctors.Where(d => d.Gender == gender_name);
                ViewBag.Gender = gender_name;
            }

            if (!string.IsNullOrEmpty(location))
            {
                doctors = doctors.Where(d => d.Address.Contains(location));
                ViewBag.Location = location;
            }

            return View(doctors.ToList());
        }


        public IActionResult DoctorDetails(int id)
        {
            var doctor = _context.Doctors
                .Include(m => m.Memberships)
                .Include(e => e.Educations )
                .Include(s => s.Specialities)
                .Include(p=>p.Appointments)
                .FirstOrDefault(d => d.Id == id);
            if (doctor != null)
            {
                return View(doctor);
            }
            else
            {
                return View("NotFoundPage");
            }      
        }


    }
}
