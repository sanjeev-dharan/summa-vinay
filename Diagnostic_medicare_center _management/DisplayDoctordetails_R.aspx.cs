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
    public partial class DisplayDoctordetails_R : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAgent();
        }
        public void GetAgent()
        {
            DoctorDetailsSql doctorDetailsSql = new DoctorDetailsSql();
            List<DoctorDetails> doctorDetails = doctorDetailsSql.DisplayDoctorDetails();
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