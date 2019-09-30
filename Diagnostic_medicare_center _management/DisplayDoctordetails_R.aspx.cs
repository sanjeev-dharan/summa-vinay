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
    public partial class DisplayDoctordetails_R : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDoctor();
        }
        public void GetDoctor()
        {
            BALAccounts Bal = new BALAccounts();   
            List<DoctorDetails> doctorDetails =Bal.displaydoctordetails() ;
        gdvDoctorDetails_r.DataSource = doctorDetails;
            gdvDoctorDetails_r.DataBind();
            if (doctorDetails.Count == 0)
            {

                lblStatus.Text = " No Doctor Details To Display";

            }
            else
            {
                headStatusdoctor.Text = "Doctor Details";
            }
        }
    }
}