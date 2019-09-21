using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IAdminDetails
    {
        void RegAdminDetails(AdminDetails adminDetails); 
        List<AdminDetails> DisplayAdminDetails();
        void ModifyAdminDetails(AdminDetails adminDetails);
        AdminDetails GetAdmin(int AdminId);
    }
}
