using Microsoft.AspNetCore.Mvc;

namespace dummyProject1_course_tcr.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "this is the index page!";
        }

        public string hello()
        {
            return "who's there!?";
        }

        
    }
}
