using DAL;
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
    public partial class ApproveAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetData();
        }

        public void GetData()
        {
            DataTable dt = new AdminDetailsSql().GetPendingAdminData();
            if (dt.Rows.Count > 0)
                gdvDataAdmin.DataSource = dt;
            gdvDataAdmin.DataBind();

        }
       

        public bool AdminApprove(int id, string tableName, string type)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ApproveAdmin";
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

        protected void gdvDataAdmin_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = gdvDataAdmin.Rows[int.Parse(e.CommandArgument.ToString())];
            int _Id = int.Parse((row.FindControl("lblIdAdmin") as Label).Text);
            string tableName = (row.FindControl("lblTableNameAdmin") as Label).Text;
            string type = e.CommandName;
            bool Result = AdminApprove(_Id, tableName, type);
            if (Result)
            {
                if (type == "approve")
                {
                    lblMsgAdmin.Text = " Request Approved Successfully!";
                }
                else
                {
                    lblMsgAdmin.Text = "Request Rejected Successfully";
                }
            }
            else
            {
                lblMsgAdmin.Text = "OOPS! Unable to Submit";
            }
            GetData();
        }

    }
    }
