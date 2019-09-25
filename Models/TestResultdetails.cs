using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class TestResultdetails
    {
        int reportId;
        int PatientId;
        int doctorid;
        int medicareService;
        int agentId;
         string  servicedate;
         string testresultdate;
        string diag1_normal_value;
        string diag1_actual_value;
        string diag2_normal_value;
        string diag2_actual_value;
        string diag3_normal_value ;
        string diag3_actual_value ;
        string diag4_normal_value;
        string diag4_actual_value;
        string diag5_normal_value;
        string diag5_actual_value;
        string diag6_normal_value;
        string diag6_actual_value;
        string doctor_comments;
        string otherinfo;

        public string Servicedate
        {
            get
            {
                return servicedate;
            }

            set
            {
                servicedate = value;
            }
        }

        public string Testresultdate
        {
            get
            {
                return testresultdate;
            }

            set
            {
                testresultdate = value;
            }
        }

        public string Diag1_normal_value
        {
            get
            {
                return diag1_normal_value;
            }

            set
            {
                diag1_normal_value = value;
            }
        }

        public string Diag1_actual_value
        {
            get
            {
                return diag1_actual_value;
            }

            set
            {
                diag1_actual_value = value;
            }
        }

        public string Diag2_normal_value
        {
            get
            {
                return diag2_normal_value;
            }

            set
            {
                diag2_normal_value = value;
            }
        }

        public string Diag2_actual_value
        {
            get
            {
                return diag2_actual_value;
            }

            set
            {
                diag2_actual_value = value;
            }
        }

        public string Diag3_normal_value
        {
            get
            {
                return diag3_normal_value;
            }

            set
            {
                diag3_normal_value = value;
            }
        }

        public string Diag3_actual_value
        {
            get
            {
                return diag3_actual_value;
            }

            set
            {
                diag3_actual_value = value;
            }
        }

        public string Diag4_normal_value
        {
            get
            {
                return diag4_normal_value;
            }

            set
            {
                diag4_normal_value = value;
            }
        }

        public string Diag4_actual_value
        {
            get
            {
                return diag4_actual_value;
            }

            set
            {
                diag4_actual_value = value;
            }
        }

        public string Diag5_normal_value
        {
            get
            {
                return diag5_normal_value;
            }

            set
            {
                diag5_normal_value = value;
            }
        }

        public string Diag5_actual_value
        {
            get
            {
                return diag5_actual_value;
            }

            set
            {
                diag5_actual_value = value;
            }
        }

        public string Diag6_normal_value
        {
            get
            {
                return diag6_normal_value;
            }

            set
            {
                diag6_normal_value = value;
            }
        }

        public string Diag6_actual_value
        {
            get
            {
                return diag6_actual_value;
            }

            set
            {
                diag6_actual_value = value;
            }
        }

        public string Doctor_comments
        {
            get
            {
                return doctor_comments;
            }

            set
            {
                doctor_comments = value;
            }
        }

        public string Otherinfo
        {
            get
            {
                return otherinfo;
            }

            set
            {
                otherinfo = value;
            }
        }

        //public int ReportId
        //{
        //    get
        //    {
        //        return reportId;
        //    }

        //    set
        //    {
        //        reportId = value;
        //    }
        //}

        public int PatientId1
        {
            get
            {
                return PatientId;
            }

            set
            {
                PatientId = value;
            }
        }

        public int Doctorid
        {
            get
            {
                return doctorid;
            }

            set
            {
                doctorid = value;
            }
        }

        public int MedicareService
        {
            get
            {
                return medicareService;
            }

            set
            {
                medicareService = value;
            }
        }

        public int AgentId
        {
            get
            {
                return agentId;
            }

            set
            {
                agentId = value;
            }
        }

        public TestResultdetails()
        {
                
        }
        public TestResultdetails(int PatientId,
        int doctorid,
        int medicareService,
        int agentId, string servicedate, string testresultdate,string diag1_normal_value,string diag1_actual_value, string diag2_normal_value, string diag2_actual_value,string diag3_normal_value,string diag3_actual_value, string diag4_normal_value,
        string diag4_actual_value,
        string diag5_normal_value,
        string diag5_actual_value,
        string diag6_normal_value,
        string diag6_actual_value,
        string doctor_comments,
        string otherinfo)
        {
           
            this.PatientId = PatientId;
            this.doctorid = Doctorid;
            this.medicareService = medicareService;
            this.agentId = agentId;
            this.servicedate = servicedate;
            this.testresultdate = testresultdate;
            this.Diag1_normal_value = diag1_normal_value;
            this.Diag1_actual_value = diag1_actual_value;
            this.Diag2_normal_value = diag2_normal_value;
            this.Diag3_actual_value = diag3_actual_value;
            this.Diag4_normal_value = diag4_normal_value;
            this.Diag4_actual_value = diag4_actual_value;
            this.Diag5_normal_value = diag5_normal_value;
            this.Diag5_actual_value = diag5_actual_value;
            this.Diag6_normal_value = diag6_actual_value;
            this.Diag6_actual_value = diag6_actual_value;
            this.Doctor_comments = doctor_comments;
            this.Otherinfo = otherinfo;

                
        }
    }
}
