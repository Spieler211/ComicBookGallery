using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            /*//Redirect Result = Action Content Type
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday) {

                return Redirect("/");
            }

            //Content Result = Action Content Type
            return Content("Hello from the Comic Book Controller!");*/

            return View();
        }
    }
}