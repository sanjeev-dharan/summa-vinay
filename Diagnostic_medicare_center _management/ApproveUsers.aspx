<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApproveUsers.aspx.cs" Inherits="Diagnostic_medicare_center__management.ApproveUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div id="txtapprove" style="margin-top:5%;margin-left:5%;">
    <center>
        <asp:Label runat="server" ID="lblMsg"></asp:Label>
    </center>
    <asp:GridView runat="server" ID="gdvData" AutoGenerateColumns="false" style="background-color:white;color:darkblue;" 
        CssClass="table table-responsive" OnRowCommand="gdvData_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="#" >
                    <ItemTemplate>
                        
                        <asp:Label ID="lblId" runat="server" Text='<%# Eval("ID") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="User Type">
                    <ItemTemplate>
                        <asp:Label ID="lblTableName" runat="server" Text='<%# Eval("TableName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="First Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblFirstName" runat="server" Text='<%# Eval("FirstName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Last Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblLastName" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Age" >
                    <ItemTemplate>
                        <asp:Label ID="lblAge" runat="server" Text='<%# Eval("Age") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Gender" >
                    <ItemTemplate>
                        <asp:Label ID="lblGender" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Contact Number" >
                    <ItemTemplate>
                        <asp:Label ID="lblContactNumber" runat="server" Text='<%# Eval("ContactNumber") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="User Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblUsername" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="Password" >
                    <ItemTemplate>
                        <asp:Label ID="lblPassword" runat="server" Text='<%# Eval("Password") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:ButtonField ButtonType="Image" ImageUrl="images/ok.png" HeaderText="Approve" CommandName="approve" />
            <asp:ButtonField ButtonType="Image" ImageUrl="images/cancel.png" HeaderText="Reject" CommandName="Reject" />
            </Columns>
    </asp:GridView>
</div>
</asp:Content>
