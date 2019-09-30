<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Displaypatientdetails.aspx.cs" Inherits="Diagnostic_medicare_center__management.Displaypatientdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    
    <asp:Label runat="server" ID="headStatusPatient" CssClass="titleStatus"></asp:Label>
    <br />
    <br />
     <asp:GridView runat="server" ID="gdvPatientDetails" OnRowDeleting="gdvPatientDetails_RowDeleting"
             AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientfname" runat="server" Text='<%# Eval("FirstName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
              <%--  <asp:TemplateField HeaderText="LastName">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientlastName" runat="server" Text='<%# Eval("LastName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                  <asp:TemplateField HeaderText=" Age">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientage" runat="server" Text='<%# Eval("Age1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientgender" runat="server" Text='<%# Eval("Gender1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                 <asp:TemplateField HeaderText="DoB">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientdob" runat="server" Text='<%# Eval("DoB1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="ContactNumber">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientcntct" runat="server" Text='<%# Eval("ContactNumber1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="AltContactNumber" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientaltcntct" runat="server" Text='<%# Eval("AltContactNumber1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="EmailID">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientemail" runat="server" Text='<%# Eval("EmailID1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="UserName">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientusername" runat="server" Text='<%# Eval("UserName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientpassword" runat="server" Text='<%# Eval("Password1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                 <asp:TemplateField HeaderText="AddressLine1">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientaddressline1" runat="server" Text='<%# Eval("AddressLine11") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="AddressLine2" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientaddressline2" runat="server" Text='<%# Eval("AddressLine21") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientcity" runat="server" Text='<%# Eval("City1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                  <asp:TemplateField HeaderText="State">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientstate" runat="server" Text='<%# Eval("State1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>     
                  <asp:TemplateField HeaderText="Zipcode">
                    <ItemTemplate>
                        <asp:Label ID="lblpatientzipcode" runat="server" Text='<%# Eval("Zipcode1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                         
                <asp:CommandField ButtonType="Link" ShowDeleteButton="true" HeaderText="Action"  ControlStyle-ForeColor="DarkBlue" ControlStyle-Font-Underline="true"/>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
     
        <br />
        <br />
        <br />
    <center> <asp:Label runat="server" ID="lblStatusPatient"  CssClass="delmessage"></asp:Label></center>
</asp:Content>
