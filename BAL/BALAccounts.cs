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
        PatientDetailsSql patientDetailsSql = new PatientDetailsSql();   
        public  List<PatientDetails> DisplayPatientDetail()
        {
           return patientDetailsSql.DisplayPatientDetails();
        }
        public void removepatient(string name)
        {
            patientDetailsSql.RemovePatient(name);
        }
        public bool regpatientdetails(PatientDetails patientdetails)
        {
            return patientDetailsSql.RegPatientDetails(patientdetails);
        }
        DoctorDetailsSql doctordetailssql = new DoctorDetailsSql();
        public List<DoctorDetails> displaydoctordetails()
        {
            return doctordetailssql.DisplayDoctorDetails();
        }
        public void removedoctor(int id)
        {
            doctordetailssql.RemoveDoctor(id);
        } 
        public bool regdoctordetails(DoctorDetails doctordetails)
        {
           return doctordetailssql.RegDoctorDetails(doctordetails);
        }
        AdminDetailsSql admindetailssql = new AdminDetailsSql();
        public List<AdminDetails> displayadmindetails()
        {
            return admindetailssql.DisplayAdminDetails();
        }
        public bool regadmin(AdminDetails admindetails)
        {
          return admindetailssql.RegAdminDetails(admindetails);
        }


        AgentDetailsSql agentdetailssql = new AgentDetailsSql();
        public List<AgentDetails> displayagentdetails()
        {
            return agentdetailssql.DisplayAgentDetails();
        }
        public void removeagent(string name)
        {
            agentdetailssql.RemoveAgent(name);
        }
        public bool regagent(AgentDetails agentdetails)
        {
            return agentdetailssql.RegAgentDetails(agentdetails);
        }
        MedicareServicesSql medicareservicessql = new MedicareServicesSql();
        public List<MedicareServices> displaymedicareservices()
        {
            return medicareservicessql.DisplayMedicareServices();
        }
        public void addmedicareservices(MedicareServices medicareservices)
        {
            medicareservicessql.AddMedicareServices(medicareservices);
        }
        public void modifymedicareservices(MedicareServices medicareservices)
        {
            medicareservicessql.ModifyMedicareServices(medicareservices);
        }
        public void removemedicareservices(string name)
        {
            medicareservicessql.RemoveMedicareServices(name);
        }
        Testresultsql testresultssql = new Testresultsql();
        public void addtestresults(TestResultdetails testresults)
        {
            testresultssql.AddTestResults(testresults);
        }
        public List<TestResultdetails> displaytestresults()
        {
            return testresultssql.DisplayTestResults();
        }
        public void modifytestresults(TestResultdetails testresults)
        {
            testresultssql.ModifyTestResults(testresults);
        }
            
    }
}
