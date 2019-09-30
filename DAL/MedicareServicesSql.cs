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
    public class MedicareServicesSql : IMedicareServices
    {
        public void AddMedicareServices(MedicareServices medicareservices)
        {
            try
            {
                SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
                SqlCommand _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnection;
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.CommandText = "addmedicareservices";
                _sqlCommand.Parameters.AddWithValue("@MedicareService", medicareservices.Medicare_service1);
                _sqlCommand.Parameters.AddWithValue("@ServiceDescription", medicareservices.Service_Description1);
                _sqlCommand.Parameters.AddWithValue("@Amount", medicareservices.Amount1);
                _sqlConnection.Open();
                int result = _sqlCommand.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (Exception ex)
            {

            }
        }

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

        public List<MedicareServices> DisplayMedicareServices()
        {
            try
            {
                SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
                SqlCommand _sqlCommand = new SqlCommand("getmedicareservices", _sqlConnection);
                _sqlCommand.CommandType = CommandType.Text;
                _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _sqlCommand.Connection = _sqlConnection;
                SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                DataTable _dataTable = new DataTable();
                _sqlDataAdapter.Fill(_dataTable);
                List<MedicareServices> medicareservices = new List<MedicareServices>();
                if (_dataTable.Rows.Count > 0)
                {
                    foreach (DataRow _dataRow in _dataTable.Rows)
                    {
                        medicareservices.Add(new MedicareServices(
                             int.Parse(_dataRow["MedicareServicesId"].ToString()),
                            _dataRow["Medicare_service"].ToString(),
                            _dataRow["Service_Description"].ToString(),
                            int.Parse(_dataRow["Amount"].ToString())


                            )



                            );

                    }
                    return medicareservices;
                }
                else
                {
                    return new List<MedicareServices>();
                }
            }
            catch(Exception ex)
            {
                return new List<MedicareServices>();

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

        public void ModifyMedicareServices(MedicareServices medicareservices)
        {
            try
            {
                SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
                _sqlConnection.Open();
                SqlCommand _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnection;
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.CommandText = "modifymedicareservices";
                _sqlCommand.Parameters.AddWithValue("@medicareservicesid", medicareservices.MedicareServicesId1);
                _sqlCommand.Parameters.AddWithValue("@MedicareService", medicareservices.Medicare_service1);
                _sqlCommand.Parameters.AddWithValue("@ServiceDescription", medicareservices.Service_Description1);
                _sqlCommand.Parameters.AddWithValue("@Amount", medicareservices.Amount1);
                int res = _sqlCommand.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch(Exception ex)
            {

            }
        }

        public void RemoveMedicareServices(string name)
        {
            try
            {
                SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
                _sqlConnection.Open();
                SqlCommand _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnection;
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.CommandText = "removemedicareservices";
                _sqlCommand.Parameters.AddWithValue("@MedicareService", name);
                int res = _sqlCommand.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch(Exception ex)
            {

            }

        }
    }
}
