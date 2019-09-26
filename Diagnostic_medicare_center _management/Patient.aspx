<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="Diagnostic_medicare_center__management.Patient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <br />
      <br />
      <br />
    <center>
     <h2 style="text-align:center"   class="form-signin-heading" > Book Appointment </h2>
    <br />
      <br />
      <br />
    <asp:Label runat="server" ID="txtappointment" >Select Appointment Date</asp:Label>
   <asp:TextBox runat="server" ID="txtappoint"  TextMode="Date" ></asp:TextBox>
        </center>
    
    </asp:Content>