<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="Diagnostic_medicare_center__management.Patient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
 <center>   
     <h2 style="text-align:center"   class="form-signin-heading" > Book Appointment </h2>
   <asp:Table runat="server" class="table table-responsive">
       <asp:TableRow>
           <asp:TableCell>
  <asp:Label runat="server" ID="txtappointment" >Select Appointment Date</asp:Label>
           </asp:TableCell>
           <asp:TableCell>
<asp:TextBox runat="server" ID="txtappoint" CssClass="form-control"  TextMode="Date" ClientIDMode="Static"></asp:TextBox>
           </asp:TableCell>
       </asp:TableRow>
         <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtdoctorid">DoctorId</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                   <asp:DropDownList ID="ddldoctor" runat="server" CssClass="form-control" ClientIDMode="Static" ></asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
         <asp:TableRow>
                <asp:TableCell>
            <asp:Label runat="server" for="txtmedicareservice">MedicareServiceId</asp:Label>        
             </asp:TableCell>
                <asp:TableCell>
                     <asp:DropDownList ID="ddlmedicareservices" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
       <asp:TableRow>
           
           <asp:TableCell ColumnSpan="2">
               <center>
                  <asp:Button ID="btnsubmit" CssClass="btn btn-lg btn-primary" runat="server" Text="BookAppointment" OnClick="btnsubmit_Click"  OnClientClick="return Appointment_validate()" ClientIDMode="Static"/>
               </center></asp:TableCell>
       </asp:TableRow>
     
      


   </asp:Table>
     
  
   
        </center>
    
    </asp:Content>