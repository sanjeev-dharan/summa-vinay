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
    public partial class Displaydoctordetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDoctor();
        }
        public void GetDoctor()
        {
            BALAccounts Bal = new BALAccounts();
            List<DoctorDetails> doctorDetails = Bal.displaydoctordetails();
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
            BALAccounts Bal = new BALAccounts();
            GridViewRow row = gdvDoctorDetails.Rows[e.RowIndex];
            int id = int.Parse((row.FindControl("lblID") as Label).Text);
            DoctorDetails doctordetails = new DoctorDetails();
            List<DoctorDetails> docdetails = Bal.displaydoctordetails();

            if (docdetails.Count > 0)
            {
                for (int i = 0; i < docdetails.Count; i++)
                {
                    if (docdetails[i].DoctorID1 == id)
                    {
                        docdetails.RemoveAt(i);
                    }
                }

                Bal.removedoctor(id);
                lblStatus.Text = "Doctor Details Deleted Successfully";
                GetDoctor();

            }




        }
        


    }
    }
