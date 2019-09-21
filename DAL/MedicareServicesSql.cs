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
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "insert into Medicare_services(Medicare_service,Service_Description,Amount) values (@MedicareService,@ServiceDescription,@Amount)";
            _sqlCommand.Parameters.AddWithValue("@MedicareService", medicareservices.Medicare_service1);
            _sqlCommand.Parameters.AddWithValue("@ServiceDescription", medicareservices.Service_Description1);
            _sqlCommand.Parameters.AddWithValue("@Amount", medicareservices.Amount1);
        }

        public List<MedicareServices> DisplayMedicareServices()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "select * from Medicare_services";
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

        public void ModifyMedicareServices(MedicareServices medicareservices)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "update  Medicare_services set Service_Description=@servicedescription,Amount=@amount where Medicare_service=@medicareservice";
            //    _sqlCommand.Parameters.AddWithValue("@MedicareService", medicareservices.Medicare_service1);
            _sqlCommand.Parameters.AddWithValue("@ServiceDescription", medicareservices.Service_Description1);
            _sqlCommand.Parameters.AddWithValue("@Amount", medicareservices.Amount1);
        }

        public void RemoveMedicareServices(string name)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "delete  from Medicare_services where Medicare_service=@MedicareService";
            _sqlCommand.Parameters.AddWithValue("@MedicareService", name);
            int res = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }
    }
}
