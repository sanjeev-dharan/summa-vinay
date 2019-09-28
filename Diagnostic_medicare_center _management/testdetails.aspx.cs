using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;
using System.Data;
namespace Diagnostic_medicare_center__management
{
    public partial class testdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getdata();
            }
        }
        public void getdata()
        {
            Testresultsql testresultssql = new Testresultsql();
            DataSet ds = testresultssql.Getalldata();
            ddlpatient.DataSource = ds.Tables[0];
            ddlpatient.DataValueField = "vid";
            ddlpatient.DataTextField = "ID";
            ddlpatient.DataBind();
            ddlpatient.Items.Insert(0, new ListItem { Value = "", Text = "--select--" });

            ddldoctor.DataSource = ds.Tables[1];
            ddldoctor.DataValueField = "vid";
            ddldoctor.DataTextField = "ID";
            ddldoctor.DataBind();
            ddldoctor.Items.Insert(0, new ListItem { Value = "", Text = "--select--" });
            ddlmedicareservices.DataSource = ds.Tables[2];
            ddlmedicareservices.DataValueField = "vid";
            ddlmedicareservices.DataTextField = "ID";
            ddlmedicareservices.DataBind();
            ddlmedicareservices.Items.Insert(0, new ListItem { Value = "", Text = "--select--" });
            ddlagent.DataSource = ds.Tables[3];
            ddlagent.DataValueField = "vid";
            ddlagent.DataTextField = "ID";
            ddlagent.DataBind();
            ddlagent.Items.Insert(0, new ListItem { Value = "", Text = "--select--" });
        }
        protected void testresultssubmit_Click(object sender, EventArgs e)
        {
            Testresultsql testresultssql = new Testresultsql();
            
                TestResultdetails testresultdetails = new TestResultdetails
                {
                    PatientId1 = int.Parse(ddlpatient.SelectedItem.Value),
                    Doctorid = int.Parse(ddldoctor.SelectedItem.Value),
                    MedicareService = int.Parse(ddlmedicareservices.SelectedItem.Value),
                    AgentId = int.Parse(ddlagent.SelectedItem.Value),
                    Servicedate = txtservicedate.Text,
                    Testresultdate = txttestresultdate.Text,
                    Diag1_normal_value = txtdiag1_normal_value.Text,
                    Diag1_actual_value = txtdiag1_actual_value.Text,
                    Diag2_normal_value = txtdiag2_normal_value.Text,
                    Diag2_actual_value = txtdiag2_actual_value.Text,
                    Diag3_normal_value = txtdiag3_normal_value.Text,
                    Diag3_actual_value = txtdiag3_actual_value.Text,
                    Diag4_normal_value = txtdiag4_normal_value.Text,
                    Diag4_actual_value = txtdiag4_actual_value.Text,
                    Diag5_normal_value = txtdiag5_normal_value.Text,
                    Diag5_actual_value = txtdiag5_actual_value.Text,
                    Diag6_normal_value = txtdiag6_normal_value.Text,
                    Diag6_actual_value = txtdiag6_actual_value.Text,
                    Doctor_comments = txtDoctorComments.Text,
                    Otherinfo = txtOtherInformation.Text
                };
                testresultssql.AddTestResults(testresultdetails);
            


        }
    }
}