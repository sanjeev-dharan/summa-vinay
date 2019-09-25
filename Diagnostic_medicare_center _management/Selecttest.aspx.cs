using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Diagnostic_medicare_center__management
{
    public partial class Selecttest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnviewresults_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TestResultsdisplay.aspx");
        }

        protected void btnupdateresults_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/testdetails.aspx");
        }
    }
}