using DoctorsAppointment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorsAppointment.Controllers
{
    
    public class ListDoctorsController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        public IActionResult RetriveDoctors()
        {
            var doctors = _context.Doctors;
            return View(doctors.ToList());
        }
    }
}
