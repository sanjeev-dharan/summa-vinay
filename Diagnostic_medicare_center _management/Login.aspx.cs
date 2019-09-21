using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace Diagnostic_medicare_center__management
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtBtnLogin_Click(object sender, EventArgs e)
        {
            
           Session["ddlRoleList"]=ddlRoleList.SelectedValue.ToString();
            Session["txtUserName"] = txtUserName.Text;
            Session["txtpassword"] = txtpassword.Text;
            lblindex.Text = "";
            if (ddlRoleList.SelectedValue.ToString() == "Admin")
            {
                int count = 0;
                AdminDetailsSql adminDetailsSql = new AdminDetailsSql();
                List<AdminDetails> adminDetails = adminDetailsSql.DisplayAdminDetails();
             foreach (var admin in adminDetails)
                {
                    if ((admin.UserName1 == txtUserName.Text) && (admin.Password1 == txtpassword.Text))
                    {

                        count++;
                    }

                }
                if (count == 1)
                {
                    lblMsg.Text = "Login successfull";
                    Response.Redirect("~/Admin.aspx");
                }
                else
                {
                    lblMsg.Text = "Invalid username or password";
                }
                
            }
           else if (ddlRoleList.SelectedValue == "Doctor")
            {
               
                int count = 0;
                DoctorDetailsSql doctorDetailsSql = new DoctorDetailsSql();
                List<DoctorDetails> doctorDetails = doctorDetailsSql.DisplayDoctorDetails();
                foreach (var doctor in doctorDetails)
                {
                    if ((doctor.UserName1 == txtUserName.Text) && (doctor.Password1 == txtpassword.Text))
                    {

                        count++;
                    }

                }
                if (count == 1)
                {
                    lblMsg.Text = "Login successfull";
                    Response.Redirect("~/Doctor.aspx");
                }
                else
                {
                    lblMsg.Text = "Invalid username or password";
                }

            }
            else if (ddlRoleList.SelectedValue == "Patient")
            {
                int count = 0;
                PatientDetailsSql patientDetailsSql = new PatientDetailsSql();
                List<PatientDetails> patientDetails = patientDetailsSql.DisplayPatientDetails();
                foreach (var patient in patientDetails)
                {
                    if ((patient.UserName1 == txtUserName.Text) && (patient.Password1 == txtpassword.Text))
                    {

                        count++;
                    }

                }
                if (count == 1)
                {
                    lblMsg.Text = "Login successfull";
                    Response.Redirect("~/Patient.aspx");
                }
                else
                {
                    lblMsg.Text = "Invalid username or password";
                }

            }
            else if (ddlRoleList.SelectedValue == "Agent")
            {
                int count = 0;
                AgentDetailsSql agentDetailsSql = new AgentDetailsSql();
                List<AgentDetails> agentDetails = agentDetailsSql.DisplayAgentDetails();
                foreach (var agent in agentDetails)
                {
                    if ((agent.UserName1 == txtUserName.Text) && (agent.Password1 == txtpassword.Text))
                    {

                        count++;
                    }

                }
                if (count == 1)
                {
                    lblMsg.Text = "Login successfull";
                    Response.Redirect("~/Agent.aspx");
                }
                else
                {
                    lblMsg.Text = "Invalid username or password";
                }

            }
            else
            {
                lblindex.Text = " Please Select the Role!!";
               
            }
        }
    }
}