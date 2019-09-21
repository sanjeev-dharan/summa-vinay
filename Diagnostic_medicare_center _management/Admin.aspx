<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Diagnostic_medicare_center__management.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-3"></div>
            <div class="col-lg-6" >
        <asp:DropDownList CssClass="form-control" runat="server" ID="Roleselect" ClientIDMode="Static" style="margin-top:2%" onchange="select_Role()" >
            <asp:ListItem value="" Text="--Select--"></asp:ListItem>
            <asp:ListItem Value="1" Text="Doctor"></asp:ListItem>
            <asp:ListItem Value="2" Text="Patient"></asp:ListItem>
            <asp:ListItem Value="3" Text="Agent"></asp:ListItem>
            <asp:ListItem Value="4" Text="Medicare Services"></asp:ListItem>
        </asp:DropDownList><br/>
       
            </div>
            <div class="col-lg-3"></div>
        </div>
    </div>
</asp:Content>
