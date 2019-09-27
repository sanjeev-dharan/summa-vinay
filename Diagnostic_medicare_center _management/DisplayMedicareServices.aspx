<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplayMedicareServices.aspx.cs" Inherits="Diagnostic_medicare_center__management.DisplayMedicareServices1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <asp:Label ID="headStatusservices" runat="server" CssClass="headermsg"></asp:Label>
 <asp:GridView runat="server" ID="MserviceDetails"
             AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="MserviceDetails_RowDeleting" OnRowEditing="MserviceDetails_RowEditing" OnRowUpdating="MserviceDetails_RowUpdating">
         <AlternatingRowStyle BackColor="White" />
         <Columns>
             <asp:TemplateField HeaderText="ID" visible="false" >
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# Eval("MedicareServicesId1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Medicare Service" >
                    <ItemTemplate>
                        <asp:Label ID="lblmedicareservice" runat="server" Text='<%# Eval("Medicare_service1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
              <asp:TemplateField HeaderText="Service Description" >
                    <ItemTemplate>
                        <asp:Label ID="lblservicedescription" runat="server" Text='<%# Eval("Service_Description1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
              <asp:TemplateField HeaderText="Amount" >
                    <ItemTemplate>
                        <asp:Label ID="lblamount" runat="server" Text='<%# Eval("Amount1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
              <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" HeaderText="Action"/>
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
       
    <asp:HyperLink ID="addservices" runat="server" Text="AddMedicareServices" style="align-content:center" NavigateUrl="~/servicesForm.aspx"></asp:HyperLink>
         </center>
    <center> <asp:Label runat="server" ID="lblStatus"  CssClass="delmessage"></asp:Label></center>
</asp:Content>
