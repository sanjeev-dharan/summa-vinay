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

namespace Diagnostic_medicare_center__management
{
    public partial class EditMedicareServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetMedicareServices();
        }
        public void GetMedicareServices()
        {
            MedicareServicesSql medicareservicesSql = new MedicareServicesSql();
            List<MedicareServices> medicareservices = medicareservicesSql.DisplayMedicareServices();
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
            MedicareServicesSql medicareservicessql = new MedicareServicesSql();
            List<MedicareServices> medservices = medicareservicessql.DisplayMedicareServices();

            if (medservices.Count > 0)
            {
                for (int i = 0; i < medservices.Count; i++)
                {
                    if (medservices[i].Medicare_service1 == name)
                    {
                        medservices.RemoveAt(i);
                    }
                }
                medicareservicessql.RemoveMedicareServices(name);
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

        protected void MserviceDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
         
            MserviceDetails.EditIndex = e.NewEditIndex;
            
            LoadData();
        }

        protected void MserviceDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection _sqlconnection = ConnectionHandler.GetConnection();
            MserviceDetails.Rows[e.RowIndex].FindControl("txtmedicareservice").Focus();
            TextBox servicename = MserviceDetails.Rows[e.RowIndex].FindControl("txtmedicareservice") as TextBox;
            MserviceDetails.Rows[e.RowIndex].FindControl("txtservicedescription").Focus();
            TextBox servicedescription = MserviceDetails.Rows[e.RowIndex].FindControl("txtservicedescription") as TextBox;
            MserviceDetails.Rows[e.RowIndex].FindControl("txtamount").Focus();
            int amount = Convert.ToInt32(MserviceDetails.DataKeys[e.RowIndex].Values["txtamount"].ToString());
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

        }
    }
}