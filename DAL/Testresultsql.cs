using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    class Testresultsql : ITestResults
    {
        public void AddTestResults(TestResultdetails testresultdetails)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
        //    _sqlCommand.CommandText = "insert into MedicalTestHistory(servicedate,testresultdate,diag1_normal_value,diag1_actual_value,diag2_normal_value,diag2_actual_value,diag3_normal_value,diag3_actual_value,diag4_normal_value,diag4_actual_value,diag5_normal_value,diag5_actual_value,diag6_normal_value,diag6_actual_value,doctor_comments,otherinfo) values (@servicedate,@testresultdate,@diag1_normal_value,@diag1_actual_value,@diag2_normal_value,@diag2_actual_value,@diag3_normal_value,@diag3_actual_value,@diag4_normal_value,@diag4_actual_value,@diag5_normal_value,@diag5_actual_value,@diag6_normal_value,@diag6_actual_value,@doctor_comments,@otherinfo)";
        //    _sqlCommand.Parameters.AddWithValue("@servicedate", testresultdetails.servicedate);
        //    _sqlCommand.Parameters.AddWithValue("@testresultdate", testresultdetails.Service_Description1);
        //    _sqlCommand.Parameters.AddWithValue("@diag1_normal_value", testresultdetails.Amount1);
        //    _sqlCommand.Parameters.AddWithValue("@diag1_actual_value", testresultdetails.Amount1);
        //    _sqlCommand.Parameters.AddWithValue("@diag2_normal_value", testresultdetails.Amount1);
        //    _sqlCommand.Parameters.AddWithValue("@diag2_actual_value", testresultdetails.Amount1);
        //    _sqlCommand.Parameters.AddWithValue("@diag3_normal_value", testresultdetails.Amount1);
        //    _sqlCommand.Parameters.AddWithValue("@diag3_actual_value", testresultdetails.Amount1);
        //    _sqlCommand.Parameters.AddWithValue("@diag4_normal_value", testresultdetails.Amount1);
        //    _sqlConnection.Open();
        //    int result = _sqlCommand.ExecuteNonQuery();
        //    _sqlConnection.Close();
        }

        public List<TestResultdetails> DisplayTestResults()
        {
            throw new NotImplementedException();
        }

        public void ModifyTestResults(TestResultdetails testresultdetails)
        {
            throw new NotImplementedException();
        }

        public void RemoveTestResults(string name)
        {
            throw new NotImplementedException();
        }
    }
}
