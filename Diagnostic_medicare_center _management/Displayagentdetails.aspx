<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Displayagentdetails.aspx.cs" Inherits="Diagnostic_medicare_center__management.Displayagentdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    
    <asp:Label runat="server" ID="headStatus" CssClass="titleStatus"></asp:Label>
    <br />
    <br />

      <asp:GridView runat="server" ID="gdvAgentDetails" CssClass="gridprop"
             AutoGenerateColumns="False" OnRowDeleting="gdvAgentDetails_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentfname" runat="server" Text='<%# Eval("FirstName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:TemplateField HeaderText="LastName">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentlastName" runat="server" Text='<%# Eval("LastName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                  <asp:TemplateField HeaderText=" Age">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentage" runat="server" Text='<%# Eval("Age1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentgender" runat="server" Text='<%# Eval("Gender1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                 <asp:TemplateField HeaderText="DoB">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentdob" runat="server" Text='<%# Eval("DoB1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="ContactNumber">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentcntct" runat="server" Text='<%# Eval("ContactNumber1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="AltContactNumber">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentaltcntct" runat="server" Text='<%# Eval("AltContactNumber1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="EmailID">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentemail" runat="server" Text='<%# Eval("EmailID1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <%--<asp:TemplateField HeaderText="UserName">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentusername" runat="server" Text='<%# Eval("UserName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentpassword" runat="server" Text='<%# Eval("Password1") %>'></asp:Label>
                    </ItemTemplate>--%>
               <%-- </asp:TemplateField>    --%>
                 <asp:TemplateField HeaderText="AddressLine1">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentaddressline1" runat="server" Text='<%# Eval("AddressLine11") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                <%-- <asp:TemplateField HeaderText="AddressLine2">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentaddressline2" runat="server" Text='<%# Eval("AddressLine21") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> --%>
                 <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentcity" runat="server" Text='<%# Eval("City1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                  <asp:TemplateField HeaderText="State">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentstate" runat="server" Text='<%# Eval("State1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>     
                  <asp:TemplateField HeaderText="Zipcode">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentzipcode" runat="server" Text='<%# Eval("Zipcode1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:CommandField ButtonType="Link" ShowDeleteButton="true" HeaderText="Action"/>
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
        <center> <asp:Label runat="server" ID="lblStatusAgent"  CssClass="delmessage"></asp:Label></center>
</asp:Content>
