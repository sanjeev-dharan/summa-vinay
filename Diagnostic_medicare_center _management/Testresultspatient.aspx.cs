using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagnostic_medicare_center__management
{
    public partial class Testresultspatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTestResults();
        }
        public void GetTestResults()
        {
            try
            {
                Testresultsql testresultssql = new Testresultsql();
                DataTable dt = testresultssql.gettestdetails(int.Parse(Session["Patientid"].ToString()));
                if (dt.Rows.Count > 0)
                {
                    gdvTestresultspatient.DataSource = dt;
                    gdvTestresultspatient.DataBind();
                }
            }
            catch { }
            //Testresultsql testresultsql = new Testresultsql();
            //List<TestResultdetails> testresults = testresultsql.DisplayTestResults();
            //gdvTestresultspatient.DataSource = testresults;
            //gdvTestresultspatient.DataBind();
            //if (testresults.Count == 0)
            //{

            //    lblStatusAgent.Text = " No Test Results To Display";

            //}
            //else
            //{
            //    headStatus.Text = "Test Results";
            //}
        }

    }
}