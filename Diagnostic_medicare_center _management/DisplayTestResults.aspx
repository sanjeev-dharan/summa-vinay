<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplayTestResults.aspx.cs" Inherits="Diagnostic_medicare_center__management.DisplayTestResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView runat="server" ID="gdvTestresults" CssClass="gridprop"
             AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Servicedate">
                    <ItemTemplate>
                        <asp:Label ID="lblservicedate" runat="server" Text='<%# Eval("Servicedate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:TemplateField HeaderText="LastName">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentlastName" runat="server" Text='<%# Eval("LastName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                  <asp:TemplateField HeaderText=" Testresultdate">
                    <ItemTemplate>
                        <asp:Label ID="lbltestresultdate" runat="server" Text='<%# Eval("Testresultdate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Diag1_normal_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag1normalvalue" runat="server" Text='<%# Eval("Diag1_normal_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
                 <asp:TemplateField HeaderText="Diag1_actual_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag1actualvalue" runat="server" Text='<%# Eval("Diag1_actual_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Diag2_normal_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag2normalvalue" runat="server" Text='<%# Eval("Diag2_normal_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Diag2_actual_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag2actualvalue" runat="server" Text='<%# Eval("Diag2_actual_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Diag3_normal_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag3normalvalue" runat="server" Text='<%# Eval("Diag3_normal_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Diag3_actual_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag3actualvalue" runat="server" Text='<%# Eval("Diag3_actual_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Diag4_normal_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag4normalvalue" runat="server" Text='<%# Eval("Diag4_normal_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Diag4_actual_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag4actualvalue" runat="server" Text='<%# Eval("Diag4_actual_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Diag5_normal_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag5normalvalue" runat="server" Text='<%# Eval("Diag5_normal_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Diag5_actual_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag5actualvalue" runat="server" Text='<%# Eval("Diag5_actual_value") %>'></asp:Label>
                    </ItemTemplate>
                     </asp:TemplateField> 
                     <asp:TemplateField HeaderText="Diag6_normal_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag6normalvalue" runat="server" Text='<%# Eval("Diag6_normal_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Diag6_actual_value">
                    <ItemTemplate>
                        <asp:Label ID="lbldiag6actualvalue" runat="server" Text='<%# Eval("Diag6_actual_value") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Doctor_comments">
                    <ItemTemplate>
                        <asp:Label ID="lbldoctorcomments" runat="server" Text='<%# Eval("Doctor_comments") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Otherinfo">
                    <ItemTemplate>
                        <asp:Label ID="lblotherinfo" runat="server" Text='<%# Eval("Otherinfo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                
                
              
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
    <asp:Label runat="server" ID="headStatus" CssClass="titleStatus"></asp:Label>
</asp:Content>
