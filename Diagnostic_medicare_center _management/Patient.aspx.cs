using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Diagnostic_medicare_center__management
{
    public partial class Patient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getdata();
            }
        }
        public void getdata()
        {
            Testresultsql testresultssql = new Testresultsql();
            DataSet ds = testresultssql.Getalldata();
            ddldoctor.DataSource = ds.Tables[1];
            ddldoctor.DataValueField = "vid";
            ddldoctor.DataTextField = "ID";
            ddldoctor.DataBind();
            ddldoctor.Items.Insert(0, new ListItem { Value = "", Text = "--select--" });
            ddlmedicareservices.DataSource = ds.Tables[2];
            ddlmedicareservices.DataValueField = "vid";
            ddlmedicareservices.DataTextField = "ID";
            ddlmedicareservices.DataBind();
            ddlmedicareservices.Items.Insert(0, new ListItem { Value = "", Text = "--select--" });
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand("appointmentdetails", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.Parameters.AddWithValue("@appointmentdate", txtappoint.Text);
            _sqlCommand.Parameters.AddWithValue("@doctorid", ddldoctor.SelectedItem.Value );
            _sqlCommand.Parameters.AddWithValue("@medicareserviceid", ddlmedicareservices.SelectedItem.Value);
            int result = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}