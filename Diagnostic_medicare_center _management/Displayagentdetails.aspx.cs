using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace Diagnostic_medicare_center__management
{
    public partial class Displayagentdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAgent();
        }
        public void GetAgent()
        {
            BALAccounts Bal = new BALAccounts();
            List<AgentDetails> agentDetails = Bal.displayagentdetails();
            gdvAgentDetails.DataSource = agentDetails;
            gdvAgentDetails.DataBind();
            if (agentDetails.Count == 0)
            {

                lblStatusAgent.Text = " No Agent Details To Display";

            }
            else
            {
                headStatus.Text = "Agent Details";
            }
        }

        protected void gdvAgentDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            BALAccounts Bal = new BALAccounts();
            GridViewRow row = gdvAgentDetails.Rows[e.RowIndex];
            string name = (row.FindControl("lblAgentfname") as Label).Text;
            AgentDetails agentDetails = new AgentDetails();
            AgentDetailsSql agentDetailsSql = new AgentDetailsSql();
            List<AgentDetails> agndetails = Bal.displayagentdetails();
          if (agndetails.Count > 0)
            {
                for (int i = 0; i < agndetails.Count; i++)
                {
                    if (agndetails[i].FirstName1 == name)
                    {
                        agndetails.RemoveAt(i);
                    }
                }

                Bal.removeagent(name);
                lblStatusAgent.Text = "Agent Details Deleted Successfully";
                GetAgent();

            }
        }
    }
}
