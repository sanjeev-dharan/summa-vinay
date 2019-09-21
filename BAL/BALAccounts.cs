using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BALAccounts
    {
        AdminDetailsSql sba1 = new AdminDetailsSql();
        public void  AddBALRecord(AdminDetails admindetails)
        {
            sba1.RegAdminDetails(admindetails);
        }

    }
}
