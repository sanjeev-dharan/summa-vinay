using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;

namespace Diagnostic_medicare_center__management
{
    public partial class Doctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getappointment();
        }
        public List<Appointment> getappointment()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand("getappointments", _sqlConnection);
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.Parameters.AddWithValue("@doctorid",4);
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);

            DataTable _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            List<Appointment> appointment = new List<Appointment>();
            if (_dataTable.Rows.Count > 0)
            {
                foreach (DataRow _dataRow in _dataTable.Rows)
                {
                    appointment.Add(new Appointment
                        (
                         _dataRow["Appointmentdate"].ToString(),
                        int.Parse(_dataRow["Medicareserviceid"].ToString()),                                         
                        _dataRow["Isapproved"].ToString().Equals("True") ? true : false
                  )



                        );
                }
                return appointment;
            }
            else
            {
                return new List<Appointment>();
            }
        }
    }
}