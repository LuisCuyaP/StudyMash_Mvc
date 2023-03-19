using Microsoft.AspNetCore.Mvc;
using StudyMash_MVC.Models;

namespace StudyMash_MVC.Controllers
{
    public class MakeController : Controller
    {
        //make/bikes
        [Route("Make")]
        [Route("Make/Bikes")]
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 1, Name = "Harley Davison"};
            return View(make);

            //ContentResult CR = new ContentResult { Content = "Hello World" };
            //return CR;  

            //return Redirect("/home");
            //return RedirectToAction("Privacy","Home");
            //return new EmptyResult();
        }

        [Route("make/bikes/{year:int:length(4)}/{month:int:range(1,13)}")]
        public IActionResult ByYearMonth(int year, int month)
        {
            return Content(year.ToString() + month.ToString());
        }
    }
}
