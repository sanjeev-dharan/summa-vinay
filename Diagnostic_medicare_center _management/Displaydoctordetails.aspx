<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Displaydoctordetails.aspx.cs" Inherits="Diagnostic_medicare_center__management.Displaydoctordetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br /><br />
    
    <asp:Label runat="server" ID="headStatusdoctor" CssClass="titleStatus"></asp:Label>
    <br />
    <br />
     <asp:GridView  runat="server" ID="gdvDoctorDetails"
             AutoGenerateColumns="False" OnRowDeleting="gdvDoctorDetails_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false" >
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%# Eval("DoctorID1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblfname" runat="server" Text='<%# Eval("FirstName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:TemplateField HeaderText="LastName">
                    <ItemTemplate>
                        <asp:Label ID="lbllname" Visible="true" runat="server" Text='<%# Eval("LastName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                  <asp:TemplateField HeaderText=" Age">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorage" runat="server" Text='<%# Eval("Age1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorgender" runat="server" Text='<%# Eval("Gender1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                 <asp:TemplateField HeaderText="DoB">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctordob" runat="server" Text='<%# Eval("DoB1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="ContactNumber">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorcntct" runat="server" Text='<%# Eval("ContactNumber1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
              <%--   <asp:TemplateField HeaderText="AltContactNumber">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctoraltcntct" runat="server" Text='<%# Eval("AltContactNumber1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> --%>
                 <asp:TemplateField HeaderText="EmailID">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctoremail" runat="server" Text='<%# Eval("EmailID1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
               <%--  <asp:TemplateField HeaderText="UserName">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorusername" runat="server" Text='<%# Eval("UserName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorpassword" runat="server" Text='<%# Eval("Password1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>    
                <%-- <asp:TemplateField HeaderText="AddressLine1">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctoraddressline1" runat="server" Text='<%# Eval("AddressLine11") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="AddressLine2">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctoraddressline2" runat="server" Text='<%# Eval("AddressLine21") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> --%>
                 <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorcity" runat="server" Text='<%# Eval("City1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                 <%-- <asp:TemplateField HeaderText="State">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorstate" runat="server" Text='<%# Eval("State1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>     
                  <asp:TemplateField HeaderText="Zipcode">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorzipcode" runat="server" Text='<%# Eval("Zipcode1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> --%>
                 <asp:TemplateField HeaderText="Degree">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorDegree" runat="server" Text='<%# Eval("Degree1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Specialty">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorSpecialty" runat="server" Text='<%# Eval("Specialty1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Workhours">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorWorkhours" runat="server" Text='<%# Eval("Workhours1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="HospitalName">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorHospitalName" runat="server" Text='<%# Eval("HospitalName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="MedicareServiceID">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorMedicareServiceID" runat="server" Text='<%# Eval("MedicareServiceID1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                         
                <asp:CommandField ItemStyle-ForeColor="skyblue"  ButtonType="Link" ShowDeleteButton="true" HeaderText="Action"  ControlStyle-ForeColor="DarkBlue" ControlStyle-Font-Underline="true"/>
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
    <br/>
    <br/>
    <br/>
    <center> <asp:Label runat="server" ID="lblStatus"  CssClass="delmessage"></asp:Label></center>
    
</asp:Content>
