using Microsoft.AspNetCore.Mvc;
using dummyProject1_course_tcr.Models;

namespace dummyProject1_course_tcr.Controllers

{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string hello()
        {
            return "who's there!?";
        }

        
    }
}
