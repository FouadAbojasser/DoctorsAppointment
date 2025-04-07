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

        public IActionResult DoctorDetails()
        {
            return View();
        }
    }
}
