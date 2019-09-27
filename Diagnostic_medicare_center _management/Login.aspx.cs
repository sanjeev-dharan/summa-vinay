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
            if (ddlRoleList.SelectedValue.ToString() == "s_admin")
            {
                if((txtUserName.Text=="vinay")&&(txtpassword.Text=="123456789"))
                {
                    Response.Redirect("~/ApproveAdmin.aspx");
                }
                else
                {
                    lblMsg.Text = "Invalid Username/password ";
                }

                //var UserList = adminDetails.Where(x => x.UserName1 == txtUserName.Text && x.Password1 == txtpassword.Text).ToList();
                //if (UserList.Count > 0)
                //{
                //    if (UserList[0].Isapproved1 != true)
                //    {
                //        lblMsg.Text = "Your Account is Pending for Admin Approval";
                //    }
                //    else
                //    {
                //        lblMsg.Text = "Login successfull";
                //        Response.Redirect("~/ApproveAdmin.aspx");
                //    }
                //}
                //else
                //{
                //    lblMsg.Text = "Incorrect UserId/Password";
                //}


            }
            else if (ddlRoleList.SelectedValue.ToString() == "Admin")
            {
                
                AdminDetailsSql adminDetailsSql = new AdminDetailsSql();
                List<AdminDetails> adminDetails = adminDetailsSql.DisplayAdminDetails();
                var UserList= adminDetails.Where(x => x.UserName1 == txtUserName.Text && x.Password1 == txtpassword.Text).ToList();
                if(UserList.Count>0)
                {
                    if(UserList[0].Isapproved1!=true)
                    {
                        lblMsg.Text = "Your Account is Pending for Admin Approval";
                    }
                    else
                    {
                        lblMsg.Text = "Login successfull";
                        Response.Redirect("~/Admin.aspx");
                    }
                }
                else
                {
                    lblMsg.Text = "Incorrect UserId/Password";
                }

               
            }
           else if (ddlRoleList.SelectedValue == "Doctor")
            {
               
                
                DoctorDetailsSql doctorDetailsSql = new DoctorDetailsSql();
                List<DoctorDetails> doctorDetails = doctorDetailsSql.DisplayDoctorDetails();
                var UserList = doctorDetails.Where(x => x.UserName1 == txtUserName.Text && x.Password1 == txtpassword.Text).ToList();
                if (UserList.Count > 0)
                {
                    if (UserList[0].Isapproved1 != true)
                    {
                        lblMsg.Text = "Your Account is Pending for Admin Approval";
                    }
                    else
                    {
                        lblMsg.Text = "Login successfull";
                        Response.Redirect("~/Doctor.aspx");
                    }
                }
                else
                {
                    lblMsg.Text = "Incorrect UserId/Password";
                }

            }
            else if (ddlRoleList.SelectedValue == "Patient")
            {
                
                PatientDetailsSql patientDetailsSql = new PatientDetailsSql();
                List<PatientDetails> patientDetails = patientDetailsSql.DisplayPatientDetails();
                var UserList = patientDetails.Where(x => x.UserName1 == txtUserName.Text && x.Password1 == txtpassword.Text).ToList();
                if (UserList.Count > 0)
                {
                    if (UserList[0].Isapproved1 != true)
                    {
                        lblMsg.Text = "Your Account is Pending for Admin Approval";
                    }
                    else
                    {
                        lblMsg.Text = "Login successfull";
                        Response.Redirect("~/Patient.aspx");
                    }
                }
                else
                {
                    lblMsg.Text = "Incorrect UserId/Password";
                }


            }
            else if (ddlRoleList.SelectedValue == "Agent")
            {
                
                AgentDetailsSql agentDetailsSql = new AgentDetailsSql();
                List<AgentDetails> agentDetails = agentDetailsSql.DisplayAgentDetails();
                var UserList = agentDetails.Where(x => x.UserName1 == txtUserName.Text && x.Password1 == txtpassword.Text).ToList();
                if (UserList.Count > 0)
                {
                    if (UserList[0].Isapproved1 != true)
                    {
                        lblMsg.Text = "Your Account is Pending for Admin Approval";
                    }
                    else
                    {
                        lblMsg.Text = "Login successfull";
                        Response.Redirect("~/Agent.aspx");

                    }
                }
                else
                {
                    lblMsg.Text = "Incorrect UserId/Password";
                }

            }
            else
            {
                lblindex.Text = " Please Select the Role!!";
               
            }
        }
    }
}