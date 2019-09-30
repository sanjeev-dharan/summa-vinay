using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IPatientDetails
    {
        bool RegPatientDetails(PatientDetails patientDetails);
        List<PatientDetails> DisplayPatientDetails();
        void RemovePatient(string name);
        DataTable GetPendingApprovalData();
        bool approveUsers(int id, string tableName, string type);
    }
}
