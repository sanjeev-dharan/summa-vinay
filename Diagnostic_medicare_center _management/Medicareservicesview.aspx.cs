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
    public partial class Medicareservicesview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetMedicareServices();

        }
        public void GetMedicareServices()
        {
            BALAccounts Bal = new BALAccounts();
            List<MedicareServices> medicareservices = Bal.displaymedicareservices();
            Mservice.DataSource = medicareservices;
            Mservice.DataBind();

        }
    }
}