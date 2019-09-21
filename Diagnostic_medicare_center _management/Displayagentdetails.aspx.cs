using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            AgentDetailsSql agentDetailsSql = new AgentDetailsSql();
            List<AgentDetails> agentDetails = agentDetailsSql.DisplayAgentDetails();
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

            GridViewRow row = gdvAgentDetails.Rows[e.RowIndex];
            string name = (row.FindControl("lblAgentfname") as Label).Text;
            AgentDetails agentDetails = new AgentDetails();
            AgentDetailsSql agentDetailsSql = new AgentDetailsSql();
            List<AgentDetails> agndetails = agentDetailsSql.DisplayAgentDetails();

            if (agndetails.Count > 0)
            {
                for (int i = 0; i < agndetails.Count; i++)
                {
                    if (agndetails[i].FirstName1 == name)
                    {
                        agndetails.RemoveAt(i);
                    }
                }

                agentDetailsSql.RemoveAgent(name);
                lblStatusAgent.Text = "Agent Details Deleted Successfully";
                GetAgent();

            }
        }
    }
}
