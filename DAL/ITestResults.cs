using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Data;
namespace DAL
{
    interface ITestResults
    {
        void AddTestResults(TestResultdetails testresultdetails);
        List<TestResultdetails> DisplayTestResults();
        void ModifyTestResults(TestResultdetails testresultdetails);
        DataSet Getalldata();
      
    }
}
