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
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) ddlRoleselect.SelectedIndex = 0;
        }

        protected void btnAdminSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDetailsSql adminDetailsSql = new AdminDetailsSql();
                List<AdminDetails> adminDetail = adminDetailsSql.DisplayAdminDetails();
                AdminDetails adminDetails = new AdminDetails
                {
                    FirstName1 = txtAdminFname.Text,
                    LastName1 = txtAdminLname.Text,
                    Age1 = int.Parse(txtAge.Text),
                    Gender1 = ddlAdminGender.Text,
                    DoB1 = txtdob.Text,
                    ContactNumber1 = double.Parse(txtcntct.Text),
                    AltContactNumber1 = double.Parse(txtAltcntct.Text),
                    EmailId1 = txtEmail.Text,
                    UserName1 = txtAdminUserName.Text,
                    Password1 = txtPasswd.Text,
                    Isapproved1=false



                };
                string a = txtAdminUserName.Text;
                for (int i = 0; i < adminDetail.Count; i++)
                {
                    if (a==adminDetail[i].UserName1.ToString())
                    {
                        lblerror.Text = "User Name already exists";
                    }
                }

                adminDetailsSql.RegAdminDetails(adminDetails);
                
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnDoctorSubmit_Click(object sender, EventArgs e)
        {
            try
            {


                DoctorDetailsSql doctorDetailsSql = new DoctorDetailsSql();
                DoctorDetails doctorDetails = new DoctorDetails
                {
                    FirstName1 = txtDoctorFname.Text,
                    LastName1 = txtDoctorLname.Text,
                    Age1 = int.Parse(txtDoctorAge.Text),
                    Gender1 = ddlDoctorGender.Text,
                    DoB1 = txtDoctordob.Text,
                    ContactNumber1 = double.Parse(txtDoctorcntct.Text),
                    AltContactNumber1 = double.Parse(txtDoctorAltcntct.Text),
                    EmailID1 = txtDoctorEmail.Text,
                    UserName1 = txtDoctorUserName.Text,
                    Password1 = txtDoctorPasswd.Text,
                    AddressLine11 = txtDoctorAddress.Text,
                    AddressLine21 = txtDoctoraltAddress.Text,
                    City1 = txtDoctorcity.Text,
                    State1 = txtDoctorstate.Text,
                    Zipcode1 = int.Parse(txtDoctorZipcode.Text),
                    Degree1 = txtDoctorDegree.Text,
                    Specialty1 = txtDoctorSpeciality.Text,
                    Workhours1 = int.Parse(txtDoctorWorkhours.Text),
                    HospitalName1 = txtDoctorHspName.Text,
                    MedicareServiceID1 = int.Parse(txtDoctorMediServID.Text),
                    Isapproved1 = false
                };
                doctorDetailsSql.RegDoctorDetails(doctorDetails);
            }
            catch(Exception ex)
            {

            }
            }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            PatientDetailsSql patientDetailsSql = new PatientDetailsSql();
            PatientDetails patientDetails = new PatientDetails
            {
                FirstName1 = txtPatientFname.Text,
                LastName1 = txtPatientLname.Text,
                Age1 = int.Parse(txtPatientAge.Text),
                Gender1 = ddlPatientGender.Text,
                DoB1 = txtPatientdob.Text,
                ContactNumber1 = double.Parse(txtPatientcntct.Text),
                AltContactNumber1 = double.Parse(txtPatientAltcntct.Text),
                EmailId1= txtPatientEmail.Text,
                UserName1=txtPatientUserName.Text,
                Password1 = txtPatientPasswd.Text,
                AddressLine11 = txtPatientAddress.Text,
                AddressLine21 = txtPatientAltAddress.Text,
                City1 = txtPatientcity.Text,
                State1 = txtPatientstate.Text,
                Zipcode1 = int.Parse(txtPatientzip.Text),
                Isapproved1 = false

            };
            patientDetailsSql.RegPatientDetails(patientDetails);

        }

        protected void btnAgentsubmit_Click(object sender, EventArgs e)
        {
            AgentDetailsSql agentDetailsSql = new AgentDetailsSql();
            AgentDetails agentDetails = new AgentDetails
            {
                FirstName1 = txtAgentFname.Text,
                LastName1 = txtAgentLname.Text,
                Age1 = int.Parse(txtAgentAge.Text),
                Gender1 = ddlAgentGender.Text,
                DoB1 = txtAgentdob.Text,
                ContactNumber1 = double.Parse(txtAgentcntct.Text),
                AltContactNumber1 = double.Parse(txtAgentAltcntct.Text),
                EmailId1 = txtAgentEmail.Text,
                UserName1=txtAgentUserName.Text,
                Password1 = txtAgentPasswd.Text,
                AddressLine11 = txtAgentAddress.Text,
                AddressLine21 = txtAgentAltAddress.Text,
                City1 = txtAgentcity.Text,
                State1 = txtAgentstate.Text,

                Zipcode1 = int.Parse(txtAgentzip.Text),
                Isapproved1 = false
            };
            agentDetailsSql.RegAgentDetails(agentDetails);

        }

        [System.Web.Services.WebMethod]
        public static string checkUserName(string name)
        {
            if (name.Length>3)
            {
                return "Available";
            }
            else
            {
                return "Not Available";
            }
        }

        protected void btnAdminback_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}