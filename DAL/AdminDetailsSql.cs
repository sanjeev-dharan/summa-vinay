using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdminDetailsSql : IAdminDetails
    {
        public bool approveUsers(int id, string tableName, string type)
        {
            try
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
            catch(Exception ex)
            {
                return false;
            }
        }


        public List<AdminDetails> DisplayAdminDetails()
        {
            try
            {

                SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
                SqlCommand _sqlCommand = new SqlCommand("getadmindetails", _sqlConnection);
                _sqlCommand.CommandType = CommandType.Text;
                _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _sqlCommand.Connection = _sqlConnection;
                SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                DataTable _dataTable = new DataTable();
                _sqlDataAdapter.Fill(_dataTable);
                List<AdminDetails> adminDetails = new List<AdminDetails>();
                if (_dataTable.Rows.Count > 0)
                {
                    foreach (DataRow _dataRow in _dataTable.Rows)
                    {
                        adminDetails.Add(new AdminDetails
                            (
                            int.Parse(_dataRow["AdminId"].ToString()),
                            _dataRow["FirstName"].ToString(),
                            _dataRow["LastName"].ToString(),
                            int.Parse(_dataRow["Age"].ToString()),
                            _dataRow["Gender"].ToString(),
                            _dataRow["DoB"].ToString(),
                            double.Parse(_dataRow["ContactNumber"].ToString()),
                             double.Parse(_dataRow["AltContactNumber"].ToString()),
                             _dataRow["EmailId"].ToString(),
                             _dataRow["UserName"].ToString(),
                             _dataRow["Password"].ToString(),
                             _dataRow["Isapproved"].ToString().Equals("True") ? true : false,
                                DateTime.Parse(_dataRow["Isapproved_on"].ToString())


                        )
                          );
                    }
                    return adminDetails;
                }
                else
                {
                    return new List<AdminDetails>();
                }
            }
            catch(Exception ex)
            {
return new List<AdminDetails>();
            }
        }

      



        public DataTable GetPendingApprovalData()
        {
            try
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
            catch(Exception ex)
            {
                return new DataTable();
            }

        }
        public DataTable GetPendingAdminData()
        {
            try
            {
                SqlConnection sqlConnection = ConnectionHandler.GetConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "getpendingadmins";
                SqlDataAdapter sqlDataAdaper = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdaper.Fill(dt);
                if (dt.Rows.Count > 0)
                    return dt;
                else
                    return new DataTable();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }

        }

  

        public bool RegAdminDetails(AdminDetails adminDetails)
        {
            try
            {

                if (adminDetails != null)
                {
                    SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
                    _sqlConnection.Open();
                    SqlCommand _sqlCommand = new SqlCommand("Registeradmindetails", _sqlConnection);
                    _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    _sqlCommand.Connection = _sqlConnection;
                    _sqlCommand.Parameters.AddWithValue("@FirstName", adminDetails.FirstName1);
                    _sqlCommand.Parameters.AddWithValue("@LastName", adminDetails.LastName1);
                    _sqlCommand.Parameters.AddWithValue("@Age", adminDetails.Age1);
                    _sqlCommand.Parameters.AddWithValue("@Gender", adminDetails.Gender1);
                    _sqlCommand.Parameters.AddWithValue("@DoB", adminDetails.DoB1);
                    _sqlCommand.Parameters.AddWithValue("@ContactNumber", adminDetails.ContactNumber1);
                    _sqlCommand.Parameters.AddWithValue("@AltContactNumber", adminDetails.AltContactNumber1);
                    _sqlCommand.Parameters.AddWithValue("@Emailid", adminDetails.EmailId1);
                    _sqlCommand.Parameters.AddWithValue("@UserName", adminDetails.UserName1);
                    _sqlCommand.Parameters.AddWithValue("@Password", adminDetails.Password1);


                    int result = _sqlCommand.ExecuteNonQuery();
                    _sqlConnection.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
