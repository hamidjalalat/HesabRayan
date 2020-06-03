using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HJ_Template_MVC.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult ShowReport()
        {
            return Redirect("/Report/ReportFactor.aspx");
        }
    }
}