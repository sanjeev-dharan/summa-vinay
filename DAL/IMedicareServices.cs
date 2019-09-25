using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace DAL
{
    interface IMedicareServices
    {
        void AddMedicareServices(MedicareServices medicareservices);
        List<MedicareServices> DisplayMedicareServices();
        void ModifyMedicareServices(MedicareServices medicareservices);
        void RemoveMedicareServices(string name);
        DataTable GetPendingApprovalData();
        bool approveUsers(int id, string tableName, string type);
    }
}
