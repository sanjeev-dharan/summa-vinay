﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="Diagnostic_medicare_center__management.RegistrationForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/validation.js"></script>
 <div class="container">
        <div class="row">
            <div class="col-lg-3"></div>
            <div class="col-lg-6" >
               <h2 style="text-align:center" id="RegTitle"  class="form-signin-heading" >Registration </h2>
        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlRoleselect" ClientIDMode="Static" onchange="select_Role()" >
            <asp:ListItem value="" Text="--Select Role--"></asp:ListItem>
            <asp:ListItem Value="0" Text="Admin"></asp:ListItem>
            <asp:ListItem Value="1" Text="Doctor"></asp:ListItem>
            <asp:ListItem Value="2" Text="Patient"></asp:ListItem>
            <asp:ListItem Value="3" Text="Agent"></asp:ListItem>
        </asp:DropDownList><br/>
       
<center>      
     <asp:Label runat="server" ID="lblMsg"></asp:Label>
</center>
            </div>
            <div class="col-lg-3"></div>
        </div>
    </div>
    
    <%--Admin Registration form--%> 
    <center>
    <div id="AdminReg" runat="server" style="display:none; font-weight:bold" ClientIDMode="Static">
        <h2 style="text-align:center"   class="form-signin-heading" > Admin Registration </h2>
        <asp:Table id="txtRegAdmin" runat="server" >
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtAdminFname">First Name</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAdminFname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAdminLname">Last Name</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAdminLname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAge">Age</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAge" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="ddlAdminGender">Gender</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                   <asp:DropDownList  runat="server" ID="ddlAdminGender" ClientIDMode="Static"  >
                       <asp:ListItem value="" Text="--select--"></asp:ListItem>
                       <asp:ListItem value="Male" Text="Male"></asp:ListItem>
                        <asp:ListItem value="Female" Text="Female"></asp:ListItem>
                       </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdob">Date Of Birth</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdob" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtcntct">Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAltcntct"> Alternate Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAltcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtEmail"> Email Id</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtEmail" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAdminUserName"> UserName</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAdminUserName" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPasswd" > Password</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPasswd" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow >
                
                <asp:TableCell ColumnSpan="2"> 
                   <center><asp:Button runat="server" ID="btnAdminSubmit"  CssClass="btn btn-lg btn-primary" Text="Submit" ClientIDMode="Static" OnClick="btnAdminSubmit_Click"  OnClientClick="return admin_validate()"  /> </center>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>
        <asp:Label runat="server" ID="lblerror"></asp:Label>
        
    </div>
        <%--Doctor Registration form--%>
     <div id="DoctorReg" runat="server" style="display:none; font-weight:bold" CssClass="doc_reg" ClientIDMode="Static">
         <h2 style="text-align:center"   class="form-signin-heading" > Doctor Registration </h2>
        <asp:Table runat="server" id="tblRegDoctor">
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorFname" >First Name</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorFname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorLname">Last Name</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorLname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorAge">Age</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorAge" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="ddlDoctorGender">Gender</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                   <asp:DropDownList  runat="server" ID="ddlDoctorGender" ClientIDMode="Static"  >
            <asp:ListItem value="" Text="--select--"></asp:ListItem>
            <asp:ListItem value="Male" Text="Male"></asp:ListItem>
            <asp:ListItem value="Female" Text="Female"></asp:ListItem>
                       </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctordob">Date Of Birth</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctordob" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorcntct">Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorAltcntct"> Alternate Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorAltcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorEmail"> Email Id</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorEmail" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorUserName"> UserName</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorUserName" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorPasswd" > Password</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorPasswd" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorAddress"> Address Line 1</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorAddress" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctoraltAddress"> Address Line 2</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctoraltAddress" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorcity">City</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorcity" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorstate">State</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorstate" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
               <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorZipcode">Zip Code</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorZipcode" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorDegree"> Degree</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorDegree" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorSpeciality"> Speciality</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorSpeciality" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorWorkhours"> Workhours</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorWorkhours" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorHspName"> Hospital Name</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorHspName" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtDoctorMediServID">  Medicare Service ID</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorMediServID" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                   <center> <asp:Button runat="server" ID="btnDoctorSubmit" Text="Submit" CssClass="btn btn-lg btn-primary" ClientIDMode="Static"  OnClick="btnDoctorSubmit_Click" OnClientClick="return doctor_validate()"/> </center>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>
        
         
    </div>

        <%--Patient Registration form--%>
      <div id="PatientReg" runat="server" style="display:none; font-weight:bold" ClientIDMode="Static">
           <h2 style="text-align:center"   class="form-signin-heading" > Patient Registration </h2>
        <asp:Table runat="server" id="tblRegPatient">
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtPatientFname">First Name</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientFname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientLname">Last Name</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientLname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientAge">Age</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientAge" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="ddlPatientGender">Gender</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                   <asp:DropDownList  runat="server" ID="ddlPatientGender" ClientIDMode="Static"  >
            <asp:ListItem value="" Text="--select--"></asp:ListItem>
            <asp:ListItem value="Male" Text="Male"></asp:ListItem>
            <asp:ListItem value="Female" Text="Female"></asp:ListItem>
                       </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientdob">Date Of Birth</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientdob" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientcntct">Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientAltcntct"> Alternate Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientAltcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientEmail"> Email Id</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientEmail" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientUserName"> UserName</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientUserName" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientPasswd" > Password</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientPasswd" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientAddress"> Address Line 1</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientAddress" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtPatientAltAddress"> Address Line 2</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientAltAddress" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtPatientcity">City</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientcity" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtPatientstate">State</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientstate" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
                 </asp:TableRow>
                  <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtPatientzip">Zip Code</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtPatientzip" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                 <center><asp:Button runat="server" ID="Button1" Text="Submit" CssClass="btn btn-lg btn-primary" OnClick="Button1_Click" ClientIDMode="Static" OnClientClick="return patient_validate()"/></center>   
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>
          
          
    </div>

        <%--Agent Registration form--%>

    <div id="AgentReg" runat="server" style="display:none; font-weight:bold" ClientIDMode="Static">
         <h2 style="text-align:center"   class="form-signin-heading" > Agent Registration </h2>
        <asp:Table runat="server"  id="tblRegAgent">
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtAgentFname">First Name</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentFname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentLname">Last Name</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentLname" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentAge">Age</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentAge" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="ddlAgentGender">Gender</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                   <asp:DropDownList  runat="server" ID="ddlAgentGender" ClientIDMode="Static"  >
            <asp:ListItem value="" Text="--select--"></asp:ListItem>
            <asp:ListItem value="Male" Text="Male"></asp:ListItem>
            <asp:ListItem value="Female" Text="Female"></asp:ListItem>
                       </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentdob">Date Of Birth</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentdob" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentcntct">Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentAltcntct"> Alternate Contact Number</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentAltcntct" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentEmail"> Email Id</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentEmail" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentUserName"> UserName</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentUserName" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentPasswd" > Password</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentPasswd" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentAddress"> Address Line 1</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentAddress" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAgentAltAddress"> Address Line 2</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentAltAddress" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtAgentcity">City</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentcity" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtAgentstate">State</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentstate" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
                 </asp:TableRow>
                  <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtAgentzip">Zip Code</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAgentzip" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2" >
                  <center><asp:Button runat="server" ID="btnAgentsubmit" Text="Submit" CssClass="btn btn-lg btn-primary" ClientIDMode="Static" OnClick="btnAgentsubmit_Click" OnClientClick="return agent_validate()"/>  </center>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>
        
    </div>
        </center>
 
</asp:Content>
