using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace Diagnostic_medicare_center__management
{
    public partial class DisplayMedicareServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetMedicareServices();
        }
        public void GetMedicareServices()
        {
            MedicareServicesSql medicareservicesSql = new MedicareServicesSql();
            List<MedicareServices> medicareservices = medicareservicesSql.DisplayMedicareServices();
            MserviceDetails.DataSource = medicareservices;
            MserviceDetails.DataBind();
            if (medicareservices.Count == 0)
            {

                lblStatus.Text = "Services not available";

            }
            else
            {
                headStatusservices.Text = "Medicare Services";
            }
        }
    }
}