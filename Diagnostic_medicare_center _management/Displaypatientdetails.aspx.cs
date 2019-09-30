using BAL;
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagnostic_medicare_center__management
{
    public partial class Displaypatientdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetPatient();
        }
        public void GetPatient()
        {
            BALAccounts balAccounts = new BALAccounts();
            PatientDetailsSql patientDetailsSql = new PatientDetailsSql();
            List<PatientDetails> patientDetails = balAccounts.DisplayPatientDetail();
            gdvPatientDetails.DataSource = patientDetails;
            gdvPatientDetails.DataBind();
            if (patientDetails.Count == 0)
            {

                lblStatusPatient.Text = " No Patient Details To Display";

            }
            else
            {
                headStatusPatient.Text = "Patient Details";
            }
        }

    
        protected void gdvPatientDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            BALAccounts Bal = new BALAccounts();
            GridViewRow row = gdvPatientDetails.Rows[e.RowIndex];
            string name = (row.FindControl("lblpatientfname") as Label).Text;
            PatientDetails patientDetails = new PatientDetails();
            PatientDetailsSql patientDetailsSql = new PatientDetailsSql();
            List<PatientDetails> patdetails = patientDetailsSql.DisplayPatientDetails();

            if (patdetails.Count > 0)
            {
                for (int i = 0; i < patdetails.Count; i++)
                {
                    if (patdetails[i].FirstName1 == name)
                    {
                        patdetails.RemoveAt(i);
                    }
                }

                Bal.removepatient(name);
                lblStatusPatient.Text = "Patient Details Deleted Successfully";
                GetPatient();

            }

        }
    }
}
