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
                if(!dt.Rows[0][0].ToString().Contains("Fail"))
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

        public List<AdminDetails> DisplayAdminDetails()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "select * from Admin";
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
                         _dataRow["Password"].ToString()
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


    

    public AdminDetails GetAdmin(int AdminId)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand("updateadmindetails");
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "select top 1 * from Admin where AdminId=@adminid";
            _sqlCommand.Parameters.AddWithValue("@adminid", AdminId);
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            DataTable _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            
            if (_dataTable.Rows.Count > 0)
            {
                DataRow _dataRow = _dataTable.Rows[0];
                AdminDetails adminDetails = new AdminDetails
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
                         _dataRow["Password"].ToString()
                      )

                        ;
                return adminDetails;
            }
               
            
            else
            {
                return new AdminDetails();
            }
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

        public void ModifyAdminDetails(AdminDetails adminDetails)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "update  Admin set AdminId=@Adminid,FirstName=@Firstname,LastName=@Lastname,Age=@Age,Gender=@Gender,DoB=@DoB,ContactNumber=@ContactNumber,AltContactNumber=@AltContactNumber,EmailId=@Emailid,UserName=@UserName,Password=@Password where AdminId=@Adminid";
            _sqlCommand.Parameters.AddWithValue("@Adminid", adminDetails.AdminId1);
            _sqlCommand.Parameters.AddWithValue("@Firstname", adminDetails.FirstName1);
            _sqlCommand.Parameters.AddWithValue("@Lastname", adminDetails.LastName1);
            _sqlCommand.Parameters.AddWithValue("@Age", adminDetails.Age1);
            _sqlCommand.Parameters.AddWithValue("@Gender", adminDetails.Gender1);
            _sqlCommand.Parameters.AddWithValue("@DoB", adminDetails.DoB1);
            _sqlCommand.Parameters.AddWithValue("@ContactNumber", adminDetails.ContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@AltContactNumber", adminDetails.AltContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@Emailid", adminDetails.EmailId1);
            _sqlCommand.Parameters.AddWithValue("@UserName", adminDetails.UserName1);
            _sqlCommand.Parameters.AddWithValue("@Password", adminDetails.Password1);
         

            _sqlConnection.Open();
            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void RegAdminDetails(AdminDetails adminDetails)
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
           

            int result= _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
