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
    public class AgentDetailsSql : IAgentDetails
    {
        public List<AgentDetails> DisplayAgentDetails()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "select * from Agent";
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            DataTable _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            List<AgentDetails> agentDetails = new List<AgentDetails>();
            if (_dataTable.Rows.Count > 0)
            {
                foreach (DataRow _dataRow in _dataTable.Rows)
                {
                    agentDetails.Add(new AgentDetails
                        (
                        int.Parse(_dataRow["AgentID"].ToString()),
                        _dataRow["FirstName"].ToString(),
                        _dataRow["LastName"].ToString(),
                        int.Parse(_dataRow["Age"].ToString()),
                        _dataRow["Gender"].ToString(),
                        _dataRow["DOB"].ToString(),
                        double.Parse(_dataRow["ContactNumber"].ToString()),
                         double.Parse(_dataRow["AltContactNumber"].ToString()),
                         _dataRow["EmailID"].ToString(),
                         _dataRow["UserName"].ToString(),
                         _dataRow["password"].ToString(),
                         _dataRow["AddressLine1"].ToString(),
                         _dataRow["AddressLine2"].ToString(),
                         _dataRow["City"].ToString(),
                         _dataRow["State"].ToString(),
                         int.Parse(_dataRow["Zipcode"].ToString())
                        //_dataRow["Isapproved"].ToString() == "Yes" ? true : false,
                        //DateTime.Parse(_dataRow["Isapproved_On"].ToString())

                        ));
                }
                return agentDetails;
            }
            else
            {
                return new List<AgentDetails>();
            }
        }

        public void RemoveAgent(string name)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "delete  from Agent where FirstName=@agentname";
            _sqlCommand.Parameters.AddWithValue("@agentname", name);
            int res = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        public void ModifyAgentDetails()
        {
            throw new NotImplementedException();
        }

        public void RegAgentDetails(AgentDetails agentDetails)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand("Registeragentdetails", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.Parameters.AddWithValue("@Firstname", agentDetails.FirstName1);
            _sqlCommand.Parameters.AddWithValue("@Lastname", agentDetails.LastName1);
            _sqlCommand.Parameters.AddWithValue("@Age", agentDetails.Age1);
            _sqlCommand.Parameters.AddWithValue("@Gender", agentDetails.Gender1);
            _sqlCommand.Parameters.AddWithValue("@DoB", agentDetails.DoB1);
            _sqlCommand.Parameters.AddWithValue("@ContactNumber", agentDetails.ContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@AltContactNumber", agentDetails.AltContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@Emailid", agentDetails.EmailId1);
            _sqlCommand.Parameters.AddWithValue("@UserName", agentDetails.UserName1);
            _sqlCommand.Parameters.AddWithValue("@Password", agentDetails.Password1);
            _sqlCommand.Parameters.AddWithValue("@AddressLine1", agentDetails.AddressLine11);
            _sqlCommand.Parameters.AddWithValue("@AddressLine2", agentDetails.AddressLine21);
            _sqlCommand.Parameters.AddWithValue("@City", agentDetails.City1);
            _sqlCommand.Parameters.AddWithValue("@State", agentDetails.State1);
            _sqlCommand.Parameters.AddWithValue("@Zipcode", agentDetails.Zipcode1);

            //_sqlCommand.Parameters.AddWithValue("@Isapproved", doctorDetails.Isapproved1);
            //_sqlCommand.Parameters.AddWithValue("@IsApprovedOn", doctorDetails.Isapproved_On1);
            int result = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        public DataTable GetPendingApprovalData()
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "GetPendingUsers";
            SqlDataAdapter sqlDataAdaper = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdaper.Fill(dt);
            if (dt.Rows.Count > 0)
                return dt;
            else
                return new DataTable();
        }

        public bool approveUsers(int id, string tableName, string type)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ApproveUsers";
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@table", tableName);
            sqlCommand.Parameters.AddWithValue("@type", type);
            SqlDataAdapter sqlDataAdaper = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdaper.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (!dt.Rows[0][0].ToString().Contains("Fail"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
