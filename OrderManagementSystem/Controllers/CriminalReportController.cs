using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagementSystem.Controllers
{
    public class CriminalReportController : Controller
    {
        // GET: CriminalReport
        public ActionResult Index()
        {
            return View();
        }

        //To Do this can be expanded to call it's own repository to perform various actions as we did in Paramed
    }
}