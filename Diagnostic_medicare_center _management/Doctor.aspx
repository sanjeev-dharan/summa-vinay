<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doctor.aspx.cs" Inherits="Diagnostic_medicare_center__management.Doctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <asp:GridView runat="server" ID="gdvappointment">
      <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="AppointmentDate" >
                    <ItemTemplate>
                        <asp:Label ID="lblAppointmentDate" runat="server" Text='<%# Eval("appointmentdate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="MedicareserviceID" >
                    <ItemTemplate>
                        <asp:Label ID="lblMSID" runat="server" Text='<%# Eval("medicareserviceid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                             <asp:ButtonField ButtonType="Image" ImageUrl="images/ok.png" HeaderText="Approve" CommandName="approve" />
            <asp:ButtonField ButtonType="Image" ImageUrl="images/cancel.png" HeaderText="Reject" CommandName="Reject" />   
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
</asp:Content>
