using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HJ_Template_MVC.Report
{
    public partial class ReportFactor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Reports.Report MyReport = new Reports.Report();
            MyStiWebViewer.Report = MyReport;
        }
    }
}