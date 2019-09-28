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
            if (!IsPostBack)
            {
                getappointment();
            }
        }
        public void getappointment()
        {
            try
            {
                DataTable dt = new AppointmentSql().GetPendingAppointments(int.Parse(Session["DoctorId"].ToString()));
                if (dt.Rows.Count > 0)
                    gdvappointment.DataSource = dt;
                gdvappointment.DataBind();
            }
            catch { }
        }

        public bool ApproveAppointment(int id,  string type)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ApproveAppointment";
            sqlCommand.Parameters.AddWithValue("@id", id);
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

        protected void gdvappointment_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = gdvappointment.Rows[int.Parse(e.CommandArgument.ToString())];
            int _Id = int.Parse((row.FindControl("lbldoctorid") as Label).Text);
            string type = e.CommandName;
            bool Result = ApproveAppointment(_Id, type);
            if (Result)
            {
                if (type == "approve")
                {
                    lblMsgDoctor.Text = " Request Approved Successfully!";
                }
                else
                {
                    lblMsgDoctor.Text = "Request Rejected Successfully";
                }
            }
            else
            {
                lblMsgDoctor.Text = "OOPS! Unable to Submit";
            }
            getappointment();
        }

    }
}
    
