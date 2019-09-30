using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;
using BAL;

namespace Diagnostic_medicare_center__management
{
    public partial class medicareservicesform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtMS.Text = Request.QueryString["name"];
                txtMSDescription.Text = Request.QueryString["servicedescription"];
                txtAmount.Text = Request.QueryString["amount"];




            }
        }

        protected void btnServiceupdate_Click(object sender, EventArgs e)
        {
            BALAccounts Bal = new BALAccounts();  
            MedicareServices medicareservices = new MedicareServices
            {
                MedicareServicesId1 = int.Parse(Request.QueryString["medicareservicesid"].ToString()),
                Medicare_service1 = txtMS.Text,
                Service_Description1 = txtMSDescription.Text,
                Amount1= int.Parse(txtAmount.Text)


            };
            Bal.modifymedicareservices(medicareservices);
        }
    }
}