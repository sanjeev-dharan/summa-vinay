<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestResultsdisplay.aspx.cs" Inherits="Diagnostic_medicare_center__management.DisplayTestResults" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
        <asp:Label runat="server" ID="headStatus" CssClass="titleStatus"></asp:Label>
    <div id="displayTestResult" runat="server" class="testresult1"  >

        <asp:GridView runat="server" ID="gdvTestresults" AutoGenerateColumns="False"  BorderStyle="None" GridLines="None" Height="100%" Width="100%"<%-- OnRowCommand="examData_RowCommand"--%>>
        <Columns>
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <div class="wrap">
                        <div class="content-box">
                            <h2>
                                <asp:Label ID="LblHead" runat="server"  Text="Exam Description: "></asp:Label>
                                <asp:Label ID="lblExName" runat="server"  Text='<%# Eval("ReportId") %>'></asp:Label></h2>
                            <h6>
                                <asp:Label ID="LblSubHead1" runat="server"  Text="Exam Code: "></asp:Label>
                                <asp:Label ID="lblExId" runat="server" Text='<%# Eval("PatientId1") %>'></asp:Label></h6>
                            <h6>
                                <asp:Label ID="LblSubHead2" runat="server"  Text="Skill Set: "></asp:Label>
                                <asp:Label ID="lblSkillSet" runat="server" Text='<%# Eval("Doctorid") %>'></asp:Label></h6>
                            <h6>
                                <asp:Label ID="LblSubHead3" runat="server"  Text="Competancy Level: "></asp:Label>
                                <asp:Label ID="lblCompetancy" runat="server" Text='<%# Eval("MedicareService") %>'></asp:Label></h6>
                            <h6>
                                <asp:Label ID="LblSubHead4" runat="server"  Text="Assessment Time: "></asp:Label>
                                <asp:Label ID="lblExTime" runat="server" Text='<%# Eval("AgentId") %>'></asp:Label></h6>
                            <h6>
                               <%-- <asp:Label ID="LblSubHead5" runat="server"  Text="Assessment Date: "></asp:Label>
                                <asp:Label ID="lblExDate" runat="server" Text='<%# DateTime.Parse(Eval("Diag1_normal_value").ToString()).ToString("dd/MM/yyyy") %>'></asp:Label></h6>--%>
                           <%-- 
                            <asp:Button ID="btnDel" runat="server" CssClass="buttonDel" Text="Delete"  CommandName="DeleteButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            <asp:Button ID="btnEdit" runat="server" CssClass="buttonEdit" Text="Edit"  CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"/>--%>
                                        

                        </div>
                </ItemTemplate>
                
            </asp:TemplateField>
            <%--<asp:CommandField EditText="Edit" DeleteText="Delete" ButtonType="Button" ShowEditButton="true" ShowDeleteButton="true" />--%>
        </Columns>

    </asp:GridView>

       <%-- <Columns>--%>
            <%--<asp:TemplateField HeaderText="ReportId">
                <ItemTemplate>
                    <asp:Label ID="lblReportId" runat="server" Text='<%# Eval("ReportId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
          <%--  <asp:TemplateField HeaderText="PatientId">
                <ItemTemplate>
                    <asp:Label ID="lblPatientId" runat="server" Text='<%# Eval("PatientId1") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="doctorid">
                <ItemTemplate>
                    <asp:Label ID="lbldoctorid" runat="server" Text='<%# Eval("Doctorid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="medicareServiceid">
                <ItemTemplate>
                    <asp:Label ID="lblmedicareService" runat="server" Text='<%# Eval("MedicareService") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="agentId">
                <ItemTemplate>
                    <asp:Label ID="lblagentId" runat="server" Text='<%# Eval("AgentId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Servicedate" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="lblservicedate" runat="server" Text='<%# Eval("Servicedate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:TemplateField HeaderText="LastName">
                    <ItemTemplate>
                        <asp:Label ID="lblAgentlastName" runat="server" Text='<%# Eval("LastName1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
           <%-- <asp:TemplateField HeaderText=" Testresultdate" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="lbltestresultdate" runat="server" Text='<%# Eval("Testresultdate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="samplevalue1">
                <ItemTemplate>
                    <asp:Label ID="lbldiag1normalvalue" runat="server" Text='<%# Eval("Diag1_normal_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="actualvalue1">
                <ItemTemplate>
                    <asp:Label ID="lbldiag1actualvalue" runat="server" Text='<%# Eval("Diag1_actual_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="samplevalue2">
                <ItemTemplate>
                    <asp:Label ID="lbldiag2normalvalue" runat="server" Text='<%# Eval("Diag2_normal_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="actualvalue2">
                <ItemTemplate>
                    <asp:Label ID="lbldiag2actualvalue" runat="server" Text='<%# Eval("Diag2_actual_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="samplevalue3">
                <ItemTemplate>
                    <asp:Label ID="lbldiag3normalvalue" runat="server" Text='<%# Eval("Diag3_normal_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="actualvalue3">
                <ItemTemplate>
                    <asp:Label ID="lbldiag3actualvalue" runat="server" Text='<%# Eval("Diag3_actual_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="samplevalue4" >
                <ItemTemplate>
                    <asp:Label ID="lbldiag4normalvalue" runat="server" Text='<%# Eval("Diag4_normal_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="actualvalue4" >
                <ItemTemplate>
                    <asp:Label ID="lbldiag4actualvalue" runat="server" Text='<%# Eval("Diag4_actual_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="samplevalue5">
                <ItemTemplate>
                    <asp:Label ID="lbldiag5normalvalue" runat="server" Text='<%# Eval("Diag5_normal_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="actualvalue5">
                <ItemTemplate>
                    <asp:Label ID="lbldiag5actualvalue" runat="server" Text='<%# Eval("Diag5_actual_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="samplevalue6">
                <ItemTemplate>
                    <asp:Label ID="lbldiag6normalvalue" runat="server" Text='<%# Eval("Diag6_normal_value") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="actualvalue6">
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
            </asp:TemplateField>--%>
--%>


        <%--</Columns>--%>
     <%--   <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />--%>
    <%--</asp:GridView>--%>
         </div>

    <br />
    <br />
    <br />
    <center> <asp:Label runat="server" ID="lblStatusAgent"  CssClass="delmessage"></asp:Label></center>

</asp:Content>
