using System.Web.Mvc;

namespace SBC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult ErrorConfirmedEmail()
        {
            return View();
        }

        public PartialViewResult ErrorDowloadPartial()
        {
            return PartialView();
        }
    }
}