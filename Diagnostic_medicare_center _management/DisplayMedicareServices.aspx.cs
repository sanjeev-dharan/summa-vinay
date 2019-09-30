using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace Diagnostic_medicare_center__management
{
    public partial class DisplayMedicareServices1 : System.Web.UI.Page
    {
        
              protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetMedicareServices();
        }
        public void GetMedicareServices()
        {
            BALAccounts Bal = new BALAccounts();  
            List<MedicareServices> medicareservices = Bal.displaymedicareservices();
            MserviceDetails.DataSource = medicareservices;
            MserviceDetails.DataBind();
            if (medicareservices.Count == 0)
            {

                lblStatus.Text = "Services not available";

            }
            else
            {
                headStatusservices.Text = "Medicare Services";
            }
        }

        protected void MserviceDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MserviceDetails.Rows[e.RowIndex];
            string name = (row.FindControl("lblmedicareservice") as Label).Text;
            MedicareServices medicareservices = new MedicareServices();
            BALAccounts Bal = new BALAccounts();
            List<MedicareServices> medservices = Bal.displaymedicareservices();

            if (medservices.Count > 0)
            {
                for (int i = 0; i < medservices.Count; i++)
                {
                    if (medservices[i].Medicare_service1 == name)
                    {
                        medservices.RemoveAt(i);
                    }
                }
                Bal.removemedicareservices(name);
                lblStatus.Text = "Medicare Services Deleted successfully";
                GetMedicareServices();
            }
        }



        public void LoadData()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "select * from Medicare_services";
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            DataTable _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            MserviceDetails.DataSource = _dataTable;
            MserviceDetails.DataBind();
        }

        protected void MserviceDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection _sqlconnection = ConnectionHandler.GetConnection();
            TextBox servicename = MserviceDetails.Rows[e.RowIndex].FindControl("lblmedicareservice") as TextBox;
            TextBox servicedescription = MserviceDetails.Rows[e.RowIndex].FindControl("lblservicedescription") as TextBox;
            int amount = Convert.ToInt16(MserviceDetails.DataKeys[e.RowIndex].Values["lblamount"].ToString());
            _sqlconnection.Open();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlconnection;
            _sqlCommand.CommandText = "update  Medicare_services set Service_Description=@servicedescription,Amount=@amount where Medicare_service=@medicareservice";
            _sqlCommand.Parameters.AddWithValue("@MedicareService", servicename.Text);
            _sqlCommand.Parameters.AddWithValue("@ServiceDescription", servicedescription.Text);
            _sqlCommand.Parameters.AddWithValue("@Amount", amount);
            int i = _sqlCommand.ExecuteNonQuery();
            _sqlconnection.Close();
            MserviceDetails.EditIndex = -1;
            LoadData();
            MserviceDetails.EditIndex = -1;
            LoadData();
           

        }

        protected void MserviceDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

            GridViewRow row = MserviceDetails.Rows[e.NewEditIndex];
            string name = ((row.FindControl("lblmedicareservice") as Label).Text);
            string description = ((row.FindControl("lblservicedescription") as Label).Text);
            int amount = int.Parse((row.FindControl("lblamount") as Label).Text);
            int id = int.Parse((row.FindControl("lblId") as Label).Text);
            Response.Redirect("~/medicareservicesform.aspx?name=" + name + "&servicedescription=" + description + "&amount=" + amount + "&medicareservicesid=" + id);

        }
    }
}
    
