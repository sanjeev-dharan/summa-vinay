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
    public partial class Medicareservicesview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetMedicareServices();

        }
        public void GetMedicareServices()
        {
            MedicareServicesSql medicareservicesSql = new MedicareServicesSql();
            List<MedicareServices> medicareservices = medicareservicesSql.DisplayMedicareServices();
            Mservice.DataSource = medicareservices;
            Mservice.DataBind();

        }
    }
}