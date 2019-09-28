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
  public  class Testresultsql : ITestResults
    {
        
        public void AddTestResults(TestResultdetails testresultdetails)
        {
            
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "insert into MedicalTestHistory(PatientId,doctorid,medicareService,agentId,servicedate,testresultdate,diag1_normal_value,diag1_actual_value,diag2_normal_value,diag2_actual_value,diag3_normal_value,diag3_actual_value,diag4_normal_value,diag4_actual_value,diag5_normal_value,diag5_actual_value,diag6_normal_value,diag6_actual_value,doctor_comments,otherinfo) values (@PatientId,@doctorid,@medicareService,@agentId,@servicedate,@testresultdate,@diag1_normal_value,@diag1_actual_value,@diag2_normal_value,@diag2_actual_value,@diag3_normal_value,@diag3_actual_value,@diag4_normal_value,@diag4_actual_value,@diag5_normal_value,@diag5_actual_value,@diag6_normal_value,@diag6_actual_value,@doctor_comments,@otherinfo)";
            //_sqlCommand.Parameters.AddWithValue("@reportId", testresultdetails.ReportId);
            _sqlCommand.Parameters.AddWithValue("@PatientId", testresultdetails.PatientId1);
            _sqlCommand.Parameters.AddWithValue("@doctorid", testresultdetails.Doctorid);
            _sqlCommand.Parameters.AddWithValue("@medicareService", testresultdetails.MedicareService);
            _sqlCommand.Parameters.AddWithValue("@agentId", testresultdetails.AgentId);
            _sqlCommand.Parameters.AddWithValue("@servicedate", testresultdetails.Servicedate);
            _sqlCommand.Parameters.AddWithValue("@testresultdate", testresultdetails.Testresultdate);
            _sqlCommand.Parameters.AddWithValue("@diag1_normal_value", testresultdetails.Diag1_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag1_actual_value", testresultdetails.Diag1_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag2_normal_value", testresultdetails.Diag2_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag2_actual_value", testresultdetails.Diag2_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag3_normal_value", testresultdetails.Diag3_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag3_actual_value", testresultdetails.Diag3_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag4_normal_value", testresultdetails.Diag4_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag4_actual_value", testresultdetails.Diag4_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag5_normal_value", testresultdetails.Diag5_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag5_actual_value", testresultdetails.Diag5_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag6_normal_value", testresultdetails.Diag6_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag6_actual_value", testresultdetails.Diag6_actual_value);
            _sqlCommand.Parameters.AddWithValue("@doctor_comments", testresultdetails.Doctor_comments);
            _sqlCommand.Parameters.AddWithValue("@otherinfo", testresultdetails.Otherinfo);
            _sqlConnection.Open();
            int result = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public List<TestResultdetails> DisplayTestResults()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand("gettestresults", _sqlConnection);
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            _sqlConnection.Open();
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            DataTable _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            List<TestResultdetails> testresults = new List<TestResultdetails>();
            if (_dataTable.Rows.Count > 0)
            {
                foreach (DataRow _dataRow in _dataTable.Rows)
                {
                    testresults.Add(new TestResultdetails(
                     
                       int.Parse(_dataRow["PatientId"].ToString()),
                       int.Parse(_dataRow["doctorid"].ToString()),
                       int.Parse(_dataRow["medicareService"].ToString()),
                       int.Parse(_dataRow["agentId"].ToString()),
                        _dataRow["servicedate"].ToString(),
                        _dataRow["testresultdate"].ToString(),
                        _dataRow["diag1_normal_value"].ToString(),
                        _dataRow["diag1_actual_value"].ToString(),
                        _dataRow["diag2_normal_value"].ToString(),
                        _dataRow["diag2_actual_value"].ToString(),
                        _dataRow["diag3_normal_value"].ToString(),
                        _dataRow["diag3_actual_value"].ToString(),
                        _dataRow["diag4_normal_value"].ToString(),
                        _dataRow["diag4_actual_value"].ToString(),
                        _dataRow["diag5_normal_value"].ToString(),
                        _dataRow["diag5_actual_value"].ToString(),
                        _dataRow["diag6_normal_value"].ToString(),
                        _dataRow["diag6_actual_value"].ToString(),
                         _dataRow["doctor_comments"].ToString(),
                        _dataRow["Otherinfo"].ToString()

                        )



                        );

                }
                return testresults;
            }
            else
            {
                return new List<TestResultdetails>();
            }
        }

        public DataSet Getalldata()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand("getalldata", _sqlConnection);
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            SqlDataAdapter _sqldataadapter = new SqlDataAdapter(_sqlCommand);
            DataSet ds = new DataSet();
            _sqldataadapter.Fill(ds);
            return ds;
        }

        public DataTable gettestdetails(int id)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand("gettestresultspatient", _sqlConnection);
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.Parameters.AddWithValue("@patientid",id);
            SqlDataAdapter _sqldataadapter = new SqlDataAdapter(_sqlCommand);
            DataTable ds = new DataTable();
            _sqldataadapter.Fill(ds);
            return ds;
        }

        public void ModifyTestResults(TestResultdetails testresultdetails)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "update  MedicalTestHistory set servicedate=@servicedate,testresultdate=@testresultdate,diag1_normal_value=@diag1_normal_value,diag1_actual_value=@diag1_actual_value,diag2_normal_value=@diag2_normal_value,diag2_actual_value=@diag2_actual_value,diag3_normal_value=@diag3_normal_value,diag3_actual_value=@diag3_actual_value,diag4_normal_value=@diag4_normal_value,diag4_actual_value=@diag4_actual_value,diag5_normal_value=@diag5_normal_value,diag5_actual_value=@diag5_actual_value,diag6_normal_value=@diag6_normal_value,diag6_actual_value=@diag6_actual_value,doctor_comments=@doctor_comments,otherinfo=@otherinfo";
            //    _sqlCommand.Parameters.AddWithValue("@MedicareService", medicareservices.Medicare_service1);
            _sqlCommand.Parameters.AddWithValue("@servicedate", testresultdetails.Servicedate);
            _sqlCommand.Parameters.AddWithValue("@testresultdate", testresultdetails.Testresultdate);
            _sqlCommand.Parameters.AddWithValue("@diag1_normal_value", testresultdetails.Diag1_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag1_actual_value", testresultdetails.Diag1_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag2_normal_value", testresultdetails.Diag2_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag2_actual_value", testresultdetails.Diag2_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag3_normal_value", testresultdetails.Diag3_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag3_actual_value", testresultdetails.Diag3_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag4_normal_value", testresultdetails.Diag4_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag4_actual_value", testresultdetails.Diag4_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag5_normal_value", testresultdetails.Diag5_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag5_actual_value", testresultdetails.Diag5_actual_value);
            _sqlCommand.Parameters.AddWithValue("@diag6_normal_value", testresultdetails.Diag6_normal_value);
            _sqlCommand.Parameters.AddWithValue("@diag6_actual_value", testresultdetails.Diag6_actual_value);
            _sqlCommand.Parameters.AddWithValue("@doctor_comments", testresultdetails.Doctor_comments);
            _sqlCommand.Parameters.AddWithValue("@otherinfo", testresultdetails.Otherinfo);
        }

      
    }
}
