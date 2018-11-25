using System.Web.Mvc;

namespace ClearinkRD.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult InternalServerError()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}
