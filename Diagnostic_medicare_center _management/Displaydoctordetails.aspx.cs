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
    public partial class Displaydoctordetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDoctor();
        }
        public void GetDoctor()
        {
            DoctorDetailsSql doctorDetailsSql = new DoctorDetailsSql();
            List<DoctorDetails> doctorDetails = doctorDetailsSql.DisplayDoctorDetails();
                gdvDoctorDetails.DataSource =doctorDetails;
                gdvDoctorDetails.DataBind();
             if (doctorDetails.Count == 0)
            {
                
                lblStatus.Text = " No Doctor Details To Display";

            }
            else
            {
                headStatusdoctor.Text = "Doctor Details";
            }
        }

        protected void gdvDoctorDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            GridViewRow row = gdvDoctorDetails.Rows[e.RowIndex];
            int id = int.Parse((row.FindControl("lblID") as Label).Text);
            DoctorDetails doctordetails = new DoctorDetails();
            DoctorDetailsSql doctordetailssql = new DoctorDetailsSql();
            List<DoctorDetails> docdetails = doctordetailssql.DisplayDoctorDetails();

            if (docdetails.Count > 0)
            {
                for (int i = 0; i < docdetails.Count; i++)
                {
                    if (docdetails[i].DoctorID1 == id)
                    {
                        docdetails.RemoveAt(i);
                    }
                }

                doctordetailssql.RemoveDoctor(id);
                lblStatus.Text = "Doctor Details Deleted Successfully";
                GetDoctor();

            }




        }
        


    }
    }
