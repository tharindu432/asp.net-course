using Microsoft.AspNetCore.Mvc;
using dummyProject1_course_tcr.Models;

namespace dummyProject1_course_tcr.Controllers

{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggy = new DogViewModel() { Name="THARINDU",Age=23 };
            return View(doggy);
        }


        public IActionResult Create()
        {
            return View();
        }
        public string hello()


        {
            return "who's there!?";
        }

        
    }
}
