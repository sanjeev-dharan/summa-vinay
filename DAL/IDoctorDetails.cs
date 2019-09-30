using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDoctorDetails
    {
        bool  RegDoctorDetails(DoctorDetails doctorDetails);
        List<DoctorDetails> DisplayDoctorDetails();
        void RemoveDoctor(int DoctorID);
        DataTable GetPendingApprovalData();
        bool approveUsers(int id, string tableName, string type);
    }
}
