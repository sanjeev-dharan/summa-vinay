using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace Diagnostic_medicare_center__management
{
    public partial class DisplayTestResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTestResults();
        }
        public void GetTestResults()
        {
            BALAccounts Bal = new BALAccounts();
            List<TestResultdetails> testresults = Bal.displaytestresults();
            gdvTestresults.DataSource = testresults;
            gdvTestresults.DataBind();
            if (testresults.Count == 0)
            {

                lblStatusAgent.Text = " No Test Results To Display";

            }
            else
            {
                headStatus.Text = "Test Results";
            }
        }

       
    }
}