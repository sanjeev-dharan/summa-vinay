﻿using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IAdminDetails
    {
        bool RegAdminDetails(AdminDetails adminDetails); 
        List<AdminDetails> DisplayAdminDetails();
        DataTable GetPendingApprovalData();
        bool approveUsers(int id, string tableName, string type);
    }
}
