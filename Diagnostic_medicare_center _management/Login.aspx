<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Diagnostic_medicare_center__management.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container">
        <div class="row">
            <div class="col-lg-3"></div>
            <div class="col-lg-6">
                <h2 style="text-align:center" class="form-signin-heading"   >Sign in</h2>
       
        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlRoleList"  >
            <asp:ListItem value="" Text="--Select Role--"></asp:ListItem>
            <asp:ListItem value="s_admin" Text="Super Admin"></asp:ListItem>
            <asp:ListItem Value="Admin" Text="Admin"></asp:ListItem>
            <asp:ListItem Value="Doctor" Text="Doctor"></asp:ListItem>
            <asp:ListItem Value="Patient" Text="Patient"></asp:ListItem>
            <asp:ListItem Value="Agent" Text="Agent"></asp:ListItem>
        </asp:DropDownList><br/>
       
       <asp:TextBox runat="server" CssClass="form-control" ID="txtUserName"  placeholder="Username"></asp:TextBox><br/>
     
       <asp:TextBox runat="server" CssClass="form-control" ID="txtpassword"  placeholder="Password" TextMode="Password"></asp:TextBox><br/>
 <center>
       <asp:Button runat="server" ID="txtBtnLogin" CssClass="btn btn-lg btn-primary"  ClientIDMode= "static" OnClick="txtBtnLogin_Click" Text="Login"/><br/>
             <br />  
          <br />
     <asp:Label runat="server" CssClass="messageColor" ID="lblindex"></asp:Label>
     <asp:Label runat="server" CssClass="messageColor" ID="lblMsg"></asp:Label> <br/>
        <label>New Users</label>
       <asp:HyperLink runat="server" ID="txtHypLink" Text="Register here" NavigateUrl="RegistrationForm.aspx" ></asp:HyperLink>

 
   
      
</center>
            </div>
            <div class="col-lg-3"></div>
        </div>
    </div>
</asp:Content>
