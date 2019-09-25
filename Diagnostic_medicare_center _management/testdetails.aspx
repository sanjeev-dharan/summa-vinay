<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testdetails.aspx.cs" Inherits="Diagnostic_medicare_center__management.testdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="details" runat="server" style=" font-weight:bold" CssClass="doc_reg" ClientIDMode="Static">
        <h2 style="text-align:center"   class="form-signin-heading" > Update Test Results</h2>
   <center><asp:Table id="tbltestdetails" runat="server" CssClass="doc_reg">
           <%-- <asp:TableRow>
                <asp:TableCell>
                   <asp:Label runat="server" for="txtReportid">ReportId</asp:Label>        
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtReportid" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>--%>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtpatientid">PatientId</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtpatientid" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdoctorid">DoctorId</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdoctorid" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
         <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtmedicareservice">MedicareServiceId</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtmedicareservice" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtagentid">AgentId</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtagentid" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtservicedate">ServiceDate</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtservicedate" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txttestresultdate">ResultDate</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txttestresultdate" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag1_normal_value">diag1_normal_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag1_normal_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag1_actual_value">diag1_actual_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag1_actual_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag2_normal_value">diag2_normal_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag2_normal_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag2_actual_value">diag2_actual_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag2_actual_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
           <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag3_normal_value">diag3_normal_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag3_normal_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag3_actual_value">diag3_actual_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag3_actual_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
          <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag4_normal_value">diag4_normal_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag4_normal_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag4_actual_value">diag4_actual_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag4_actual_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
       <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag5_normal_value">diag5_normal_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag5_normal_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag5_actual_value">diag5_actual_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag5_actual_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
       <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag6_normal_value">diag6_normal_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag6_normal_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdiag6_actual_value">diag6_actual_value</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtdiag6_actual_value" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtDoctorComments">Doctor Comments</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtDoctorComments" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtOtherInformation">OtherInformation</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="txtOtherInformation" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
       <asp:TableRow >
          <asp:TableCell ColumnSpan="2">   <asp:Button runat="server" Text="Submit" ID="testresultssubmit" OnClick="testresultssubmit_Click" OnClientClick="return testResult_Validation()" />
            </center></asp:TableCell>
             
       </asp:TableRow>
       </asp:Table>
       <center> 
       </center>
        </div>

             
            
</asp:Content>
