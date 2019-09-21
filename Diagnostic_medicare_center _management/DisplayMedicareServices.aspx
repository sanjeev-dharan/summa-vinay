<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplayMedicareServices.aspx.cs" Inherits="Diagnostic_medicare_center__management.DisplayMedicareServices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <asp:Label runat="server" ID="headStatusservices" CssClass="titleStatus"></asp:Label>
     <asp:GridView runat="server" ID="MserviceDetails"
             AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="MserviceDetails_RowDeleting" onrowin>
         <AlternatingRowStyle BackColor="White" />
         <Columns>
                <asp:TemplateField HeaderText="Medicare Service" >
                    <ItemTemplate>
                        <asp:Label ID="lblfname" runat="server" Text='<%# Eval("Medicare_service1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
              <asp:TemplateField HeaderText="Service Description" >
                    <ItemTemplate>
                        <asp:Label ID="lblfname" runat="server" Text='<%# Eval("Service_Description1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
              <asp:TemplateField HeaderText="Amount" >
                    <ItemTemplate>
                        <asp:Label ID="lblfname" runat="server" Text='<%# Eval("Amount1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:CommandField ButtonType="Link" ShowDeleteButton="true" HeaderText="Action"/>
             <asp:CommandField ButtonType="Link" ShowInsertButton="true"/>
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
     <center> <asp:Label runat="server" ID="lblStatus"  CssClass="delmessage"></asp:Label></center>
</asp:Content>
