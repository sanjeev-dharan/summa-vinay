<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApproveAdmin.aspx.cs" Inherits="Diagnostic_medicare_center__management.ApproveAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="txtapprove" style="margin-top:5%;margin-left:5%;">
    <center>
        <asp:Label runat="server" ID="lblMsgAdmin" style="font-size:32px; color:white !important"></asp:Label>
    </center>
    <asp:GridView runat="server" ID="gdvDataAdmin" AutoGenerateColumns="false" style="background-color:white;color:darkblue;" 
        CssClass="table table-responsive" OnRowCommand="gdvDataAdmin_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="#" >
                    <ItemTemplate>
                        
                        <asp:Label ID="lblIdAdmin" runat="server" Text='<%# Eval("ID") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="User Type">
                    <ItemTemplate>
                        <asp:Label ID="lblTableNameAdmin" runat="server" Text='<%# Eval("TableName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="First Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblFirstNameAdmin" runat="server" Text='<%# Eval("FirstName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Last Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblLastNameAdmin" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Age" >
                    <ItemTemplate>
                        <asp:Label ID="lblAgeAdmin" runat="server" Text='<%# Eval("Age") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Gender" >
                    <ItemTemplate>
                        <asp:Label ID="lblGenderAdmin" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Contact Number" >
                    <ItemTemplate>
                        <asp:Label ID="lblContactNumberAdmin" runat="server" Text='<%# Eval("ContactNumber") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="User Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblUsernameAdmin" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="Password" >
                    <ItemTemplate>
                        <asp:Label ID="lblPasswordAdmin" runat="server" Text='<%# Eval("Password") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:ButtonField ButtonType="Image" ImageUrl="images/ok.png" HeaderText="Approve" CommandName="approve" />
            <asp:ButtonField ButtonType="Image" ImageUrl="images/cancel.png" HeaderText="Reject" CommandName="Reject" />
            </Columns>
    </asp:GridView>
</div>
</asp:Content>