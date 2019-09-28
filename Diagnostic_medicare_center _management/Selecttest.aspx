<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Selecttest.aspx.cs" Inherits="Diagnostic_medicare_center__management.Selecttest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br /><br />
    <div style="padding-left:37%">
     <asp:Label runat="server" ID="headSelectTest" CssClass="titleStatus"></asp:Label>
        </div>
    <br />
    <center>
    <asp:Button runat="server"  CssClass="btn btn-lg btn-primary" Text="View Results" ID="btnviewresults" OnClick="btnviewresults_Click"/> &nbsp
     <asp:Button runat="server"  CssClass="btn btn-lg btn-primary" Text="Update Results" ID="btnupdateresults" OnClick="btnupdateresults_Click"/>
        </center> 
</asp:Content>
