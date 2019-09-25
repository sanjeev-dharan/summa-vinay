<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="medicareservicesform.aspx.cs" Inherits="Diagnostic_medicare_center__management.medicareservicesform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <script src="Scripts/validation.js"></script>
    <center>
        <h2 style="text-align:center"   class="form-signin-heading" >  Update Medicare Services </h2>
        <asp:Table id="txtRegService" runat="server" >
             
            
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtMS">Medicare Service</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtMS" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtMSDescription">Service Description</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtMSDescription" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtAmount">Amount</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtAmount" ClientIDMode="Static"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
            <asp:TableRow >
                
                <asp:TableCell ColumnSpan="2"> 
                   
                </asp:TableCell>
            </asp:TableRow>         
            </asp:Table>
        
        <asp:Label runat="server" ID="lblerror"></asp:Label>
                    <center><asp:Button runat="server" ID="btnServiceupdate"  CssClass="btn btn-lg btn-primary" Text="Update" ClientIDMode="Static" OnClick="btnServiceupdate_Click" OnClientClick="return service_validate()"/> </center>

</asp:Content>
