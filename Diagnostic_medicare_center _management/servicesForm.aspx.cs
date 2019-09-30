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
    public partial class servicesForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnServiceSubmit_Click(object sender, EventArgs e)
        {
            BALAccounts Bal = new BALAccounts();
            MedicareServicesSql medicareServicesSql = new MedicareServicesSql();
            MedicareServices mediServices = new MedicareServices
            {
                Medicare_service1 = txtMS.Text,
                Service_Description1= txtMSDescription.Text,
                Amount1= int.Parse(txtAmount.Text)
            };
            Bal.addmedicareservices(mediServices);
            lblerror.Text = "Added Successfully";
            txtMS.Text = "";
            txtMSDescription.Text = "";
            txtAmount.Text = "";


        }
    }
}