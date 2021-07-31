using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace WosCPortTwo.Controllers
{

    public class PortfolioController : Controller
    {
        // displays site
        [HttpGet("")]

        public ViewResult About()
        {

            return View();
        }

        [HttpGet("projects")]
        
        public ViewResult Projects()
            {

                return View();
            }

        [HttpGet("contact")]
        public ViewResult Contact()
            {
                return View("contact");
            }

        // handles redirecting 
        [HttpGet("/redirectAbout")]

        public RedirectToActionResult RedirectToAbout()
            {

                return RedirectToAction("About");
            }

        [HttpGet("/redirectProject")]
        public RedirectToActionResult RedirectToProject()
            {
                return RedirectToAction("projects");
            }

            [HttpGet("/redirectContact")]
            public RedirectToActionResult RedirectToContact()
                {
                    return RedirectToAction("contact");
                }
        

    }


}