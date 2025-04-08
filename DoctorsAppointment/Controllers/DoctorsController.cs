using AspNetCoreGeneratedDocument;
using DoctorsAppointment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorsAppointment.Controllers
{
    
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        public IActionResult ListDoctors()
        {
            var doctors = _context.Doctors;
            return View(doctors.ToList());
        }

        public IActionResult DoctorDetails(int id)
        {
            var doctor = _context.Doctors
                .Include(m => m.Memberships)
                .Include(e => e.Educations )
                .Include(s => s.Specialities)
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
