using System.Web.Mvc;

namespace SBC.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
    }
}