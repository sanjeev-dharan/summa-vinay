using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IPatientDetails
    {
        void RegPatientDetails(PatientDetails patientDetails);
        List<PatientDetails> DisplayPatientDetails();
        void ModifyPatientDetails();
        void RemovePatient(string name);
    }
}
