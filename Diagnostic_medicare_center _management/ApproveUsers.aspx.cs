using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Diagnostic_medicare_center__management
{
    public partial class ApproveUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetData();
        }

        public void GetData()
        {
            DataTable dt= new AdminDetailsSql().GetPendingApprovalData();            
            if (dt.Rows.Count > 0)
                gdvData.DataSource = dt;
                gdvData.DataBind();
        }

        protected void gdvData_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = gdvData.Rows[int.Parse(e.CommandArgument.ToString())];
            int _Id = int.Parse((row.FindControl("lblId") as Label).Text);
            string tableName = (row.FindControl("lblTableName") as Label).Text;
            string type = e.CommandName;
            bool Result= new AdminDetailsSql().approveUsers(_Id, tableName, type);
            if(Result)
            {
                if(type=="approve")
                {
                    lblMsg.Text = " Request Approved Successfully!";
                }
                else
                {
                    lblMsg.Text = "Request Rejected Successfully";
                }
            }
            else
            {
                lblMsg.Text = "OOPS! Unable to Submit";
            }
            GetData();
        }
    }
}