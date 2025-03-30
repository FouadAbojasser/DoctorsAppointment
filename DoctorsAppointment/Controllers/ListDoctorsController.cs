using Microsoft.AspNetCore.Mvc;

namespace DoctorsAppointment.Controllers
{
    public class ListDoctorsController : Controller
    {
        public IActionResult RetriveDoctors()
        {
            string msg1 = "List Doctors Page";
            string msg2 = "Welcome to this Page";
            int value = 150;

            var msgs = new {msg1, msg2, value};
            return View(model: msgs);
        }
    }
}
