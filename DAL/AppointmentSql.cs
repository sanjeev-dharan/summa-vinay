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
    public class AppointmentSql
    {
        public List<Appointment> Displayappointment()
        {
            try
            {
                SqlConnection con = ConnectionHandler.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("getappointments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doctorid", 4);
                SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable _dataTable = new DataTable();
                _sqlDataAdapter.Fill(_dataTable);
                List<Appointment> Appointment_Details = new List<Appointment>();
                if (_dataTable.Rows.Count > 0)
                {
                    foreach (DataRow _dataRow in _dataTable.Rows)
                    {
                        Appointment_Details.Add(new Appointment
                            (
                          _dataRow["Appointmentdate"].ToString(),
                          int.Parse(_dataRow["Medicareserviceid"].ToString()),
                        _dataRow["Isapproved"].ToString().Equals("True") ? true : false

                            ));
                    }
                    return Appointment_Details;
                }
                else
                {
                    return new List<Appointment>();
                }
            }
            catch(Exception ex)
            {
                return new List<Appointment>();
            }
        }
        public DataTable GetPendingAppointments(int id)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionHandler.GetConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "getpendingappointments";
                sqlCommand.Parameters.AddWithValue("@docid", id);
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
    }
}
