function doctor_validate() {
    

    var name1 = document.getElementById('txtDoctorFname').value;
    var fname = /^[a-zA-Z]*$/;

    var name2 = document.getElementById('txtDoctorLname').value;
    var lname = /^[a-zA-Z]*$/;
    
    var age = document.getElementById('txtDoctorAge').value;
    var age1 = /^[0-9]*$/;
    
    var select = document.getElementById('ddlDoctorGender').value;
    var date = /^\d{2}[./-]\d{2}[./-]\d{4}$/;
    
    var dob = document.getElementById('txtDoctordob').value;
    
    var contact = document.getElementById('txtDoctorcntct').value;
    var contact1 = /^[0-9]*$/;

    var email_Pattern = /^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$/;
    var email = document.getElementById('txtDoctorEmail').value;

    var username = document.getElementById('txtDoctorUserName').value;
    var uname = /^[a-zA-Z0-9@]*$/;

    var password = document.getElementById('txtDoctorPasswd').value;

    var addressline = /^[a-zA-Z0-9@]*$/;
    var addressline1 = document.getElementById('txtDoctorAddress').value;

    var city = document.getElementById('txtDoctorcity').value;

    var state = document.getElementById('txtDoctorstate').value;

    var zipcode = document.getElementById('txtDoctorZipcode').value;

    var zipcode1 = /^[0-9]*$/;

    var degree = document.getElementById('txtDoctorDegree').value;

    var speciality = document.getElementById('txtDoctorSpeciality').value;

    var selecthours = document.getElementById('txtDoctorWorkhours').value;

    var hospitalclinic = document.getElementById('txtDoctorHspName').value;

    if (name1 == "") {
        alert("Please update the highlighted mandatory firstname field(s)");
        document.getElementById("txtDoctorFname").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorFname").focus();
        return false;
    }
    else if (name1.length <= 5 || name1.length >= 50) {
        alert("FirstName should be in between 5 and 50");
        document.getElementById("txtDoctorFname").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorFname").focus();
        return false;
    }
    else if (fname.test(name1) == false) {
        alert("FirstName should be an Alphabet");
        document.getElementById("txtDoctorFname").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorFname").focus();
        return false;
    }
    else if (name2 == "") {
        alert("Please update the highlighted mandatory lastname field(s)");
        document.getElementById("txtDoctorLname").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorLname").focus();
        return false;
    }
    else if (name2.length <= 5 || name2.length >= 50) {
        alert("LastName should be in between 5 and 50");
        document.getElementById("txtDoctorLname").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorLname").focus();

        return false;
    }
    else if (lname.test(name2) == false) {
        alert("LastName should be an Alphabet");
        document.getElementById("txtDoctorLname").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorLname").focus();
        return false;
    }
    else if (age == "") {
        alert("Please update the highlighted mandatory age field(s)");
        document.getElementById("txtDoctorAge").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorAge").focus();
        return false;
    }
    else if (age1.test(age) == false) {
        alert("Please enter a valid age");
        document.getElementById("txtDoctorAge").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorAge").focus();
        return false;
    }
    else if (age <= 1 || age >= 110) {
        alert("Please enter a valid age");
        document.getElementById("txtDoctorAge").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorAge").focus();
        return false;
    }
    else if (select == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("ddlDoctorGender").style.borderColor = "#FF0000";
        document.getElementById("ddlDoctorGender").focus();
        return false;
    }
   
     else if (dob == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("txtDoctordob").style.borderColor = "#FF0000";
        document.getElementById("txtDoctordob").focus();
        return false;

    }
    else if (contact == "") {
        alert("Please update the highlighted mandatory contact field(s)");
        document.getElementById("txtDoctorcntct").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorcntct").focus();

        return false;
    }
    else if (contact.length != 10 || contact1.test(contact) == false) {
        alert("contact number should be only valid number");
        document.getElementById("txtDoctorcntct").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorcntct").focus();
        return false;
    }
    else if (email == "") {
        alert("Please update the highlighted mandatory email field(s)");
        document.getElementById("txtDoctorEmail").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorEmail").focus();
        return false;
    }

    else if (email_Pattern.test(email) == false) {
        alert("Email should be of correct format");
        document.getElementById("txtDoctorEmail").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorEmail").focus();
        return false;
    }
    else if (username == "") {
        alert("Please update the highlighted mandatory password field(s)");
        document.getElementById("txtDoctorUserName").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorUserName").focus();
        return false;
    }
   
    //else if (uname.test(username) == false) {
    //    alert("UserName should be an Alphabet");
    //    document.getElementById("txtDoctorUserName").style.borderColor = "#FF0000";
    //    document.getElementById("txtDoctorUserName").focus();
    //    return false;
    //}
     
    else if (password == "") {
        alert("Please update the highlighted mandatory password field(s)");
        document.getElementById("txtDoctorPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorPasswd").focus();
        return false;
    }
    else if (password.length < 8 || password.length > 15) {
        alert("Give strong password");
        document.getElementById("txtDoctorPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorPasswd").focus();

        return false;
    }
    else if (addressline1 == "") {
        alert("Please update the highlighted mandatory address field(s)");
        document.getElementById("txtDoctorAddress").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorAddress").focus();
        return false;
    }
    else if (addressline1.length < 2 || addressline1.length > 100) {
        alert("Address should be between 2 to 100 characters");
        document.getElementById("txtDoctorAddress").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorAddress").focus();
        return false;
    }
    else if (city == "") {
        alert("Please update the highlighted mandatory city field(s)");
        document.getElementById("txtDoctorcity").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorcity").focus();
        return false;
    }
    else if (city.length <= 3 || city.length >= 50) {
        alert("city should be in between 3 and 50");
        document.getElementById("txtDoctorcity").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorcity").focus();

        return false;
    }

    else if (state == "") {
        alert("Please update the highlighted mandatory state field(s)");
        document.getElementById("txtDoctorstate").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorstate").focus();
        return false;
    }
    else if (state.length <= 3 || state.length >= 50) {
        alert("state should be in between 3 and 50");
        document.getElementById("txtDoctorstate").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorstate").focus();
        return false;
    }
    else if (zipcode == "") {
        alert("Please update the highlighted mandatory zipcpde field(s)");
        document.getElementById("txtDoctorZipcode").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorZipcode").focus();
        return false;
    }
    else if (zipcode1.test(zipcode) == false) {

        alert("ZipCode should be valid number");
        document.getElementById("txtDoctorZipcode").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorZipcode").focus();
        return false;
    }
    else if (degree == "") {
        alert("Please update the highlighted mandatory degree field(s)");
        document.getElementById("txtDoctorDegree").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorDegree").focus();
        return false;
    }
    else if (degree.length <= 3 || degree.length >= 50) {
        alert("Degree should be in between 3 and 50");
        document.getElementById("txtDoctorDegree").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorDegree").focus();
        return false;
    }
    else if (selecthours == "select") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("txtDoctorWorkhours").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorWorkhours").focus();
        return false;
    }
    else if (speciality == "") {
        alert("Please update the highlighted mandatory speciality field(s)");
        document.getElementById("txtDoctorSpeciality").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorSpeciality").focus();
        return false;
    }
    else if (speciality.length <= 3 || speciality.length >= 50) {
        alert("speciality should be in between 3 and 50");
        document.getElementById("txtDoctorSpeciality").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorSpeciality").focus();
        return false;
    }
    else if (hospitalclinic == "") {
        alert("Please update the highlighted mandatory hospitalclinic field(s)");
        document.getElementById("txtDoctorHspName").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorHspName").focus();
        return false;
    }
    else if (hospitalclinic.length <= 5 || hospitalclinic.length >= 100) {
        alert("HospitalClinic name should be in between 5 and 100");
        document.getElementById("txtDoctorHspName").style.borderColor = "#FF0000";
        document.getElementById("txtDoctorHspName").focus();
        return false;
    }

}

//--------------Admin Validation-------------------
function admin_validate() {

    var name1 = document.getElementById('txtAdminFname').value;
    
   
   

    var fname = /^[a-zA-Z]*$/;

    var name2 = document.getElementById('txtAdminLname').value;
    var lname = /^[a-zA-Z]*$/;

    var age = document.getElementById('txtAge').value;
    var age1 = /^[0-9]*$/;

    var select = document.getElementById('ddlAdminGender').value;
    var date = /^\d{2}[./-]\d{2}[./-]\d{4}$/;

    var dob = document.getElementById('txtdob').value;

    var contact = document.getElementById('txtcntct').value;
    var contact1 = /^[0-9]*$/;

    var email_Pattern = /^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$/;
    var email = document.getElementById('txtEmail').value;

    var username = document.getElementById('txtAdminUserName').value;
    var uname = /^[a-zA-Z0-9@]*$/;

    var password = document.getElementById('txtPasswd').value;
    if (name1 == "") {
        alert("Please update the highlighted mandatory firstname field(s)");
        document.getElementById("txtAdminFname").style.borderColor = "#FF0000";
        document.getElementById("txtAdminFname").focus();
       
        return false;
    }
   
    else if (name1.length <= 5 || name1.length >= 50) {
        alert("FirstName should be in between 5 and 50");
        document.getElementById("txtAdminFname").style.borderColor = "#FF0000";
        document.getElementById("txtAdminFname").focus();
        return false;
    }
    else if (fname.test(name1) == false) {
        alert("FirstName should be an Alphabet");
        document.getElementById("txtAdminFname").style.borderColor = "#FF0000";
        document.getElementById("txtAdminFname").focus();
        return false;
    }
     if (name2 == "") {
        alert("Please update the highlighted mandatory lastname field(s)");
        document.getElementById("txtAdminLname").style.borderColor = "#FF0000";
        document.getElementById("txtAdminLname").focus();
        return false;
    }
    else if (name2.length <= 5 || name2.length >= 50) {
        alert("LastName should be in between 5 and 50");
        document.getElementById("txtAdminLname").style.borderColor = "#FF0000";
        document.getElementById("txtAdminLname").focus();
        return false;
    }
    else if (lname.test(name2) == false) {
        alert("LastName should be an Alphabet");
        document.getElementById("txtAdminLname").style.borderColor = "#FF0000";
        document.getElementById("txtAdminLname").focus();
        return false;
    }
    else if (age == "") {
        alert("Please update the highlighted mandatory age field(s)");
        document.getElementById("txtAge").style.borderColor = "#FF0000";
        document.getElementById("txtAge").focus();
        return false;
    }
    else if (age1.test(age) == false) {
        alert("Please enter a valid age");
        document.getElementById("txtAge").style.borderColor = "#FF0000";
        document.getElementById("txtAge").focus();
        return false;
    }
    else if (age <= 1 || age >= 110) {
        alert("Please enter a valid age");
        document.getElementById("txtAge").style.borderColor = "#FF0000";
        document.getElementById("txtAge").focus();
        return false;
    }
    else if (select == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("ddlAdminGender").style.borderColor = "#FF0000";
        document.getElementById("ddlAdminGender").focus();
        return false;
    }

    else if (dob == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("txtdob").style.borderColor = "#FF0000";
        document.getElementById("txtdob").focus();
        return false;

    }
    else if (contact == "") {
        alert("Please update the highlighted mandatory contact field(s)");
        document.getElementById("txtcntct").style.borderColor = "#FF0000";
        document.getElementById("txtcntct").focus();
        return false;
    }
    else if (contact.length != 10 || contact1.test(contact) == false) {
        alert("contact number should be only valid number");
        document.getElementById("txtcntct").style.borderColor = "#FF0000";
        document.getElementById("txtcntct").focus();
        return false;
    }
    else if (email == "") {
        alert("Please update the highlighted mandatory email field(s)");
        document.getElementById("txtEmail").style.borderColor = "#FF0000";
        document.getElementById("txtEmail").focus();
        return false;
    }

    else if (email_Pattern.test(email) == false) {
        alert("Email should be of correct format");
        document.getElementById("txtEmail").style.borderColor = "#FF0000";
        document.getElementById("txtEmail").focus();
        return false;
    }
    else if (username == "") {
        alert("Please update the highlighted mandatory password field(s)");
        document.getElementById("txtAdminUserName").style.borderColor = "#FF0000";
        document.getElementById("txtAdminUserName").focus();
        return false;
    }
    else if (username.length < 5 || username.length > 15) {
        alert("USerName Length Should be in between 5 and 15.");
        document.getElementById("txtAdminUserName").style.borderColor = "#FF0000";
        document.getElementById("txtAdminUserName").focus();

        return false;
    }
    //else if (uname.test(username) == false) {
    //    alert("UserName should be an Alphabet");
    //    document.getElementById("txtAdminUserName").style.borderColor = "#FF0000";
    //    document.getElementById("txtAdminUserName").focus();
    //    return false;
    //}

    else if (password == "") {
        alert("Please update the highlighted mandatory password field(s)");
        document.getElementById("txtPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtPasswd").focus();
        return false;
    }
    else if (password.length < 8 || password.length > 15) {
        alert("Give strong password");
        document.getElementById("txtPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtPasswd").focus();

        return false;
    }
}



//----------------patient Validation--------------------


function patient_validate() {

    var name1 = document.getElementById('txtPatientFname').value;
    var fname = /^[a-zA-Z]*$/;

    var name2 = document.getElementById('txtPatientLname').value;
    var lname = /^[a-zA-Z]*$/;

    var age = document.getElementById('txtPatientAge').value;
    var age1 = /^[0-9]*$/;

    var select = document.getElementById('ddlPatientGender').value;
    var date = /^\d{2}[./-]\d{2}[./-]\d{4}$/;

    var dob = document.getElementById('txtPatientdob').value;

    var contact = document.getElementById('txtPatientcntct').value;
    var contact1 = /^[0-9]*$/;

    var email_Pattern = /^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$/;
    var email = document.getElementById('txtPatientEmail').value;

    var username = document.getElementById('txtPatientUserName').value;
    var uname = /^[a-zA-Z0-9@]*$/;

    var password = document.getElementById('txtPatientPasswd').value;

    var addressline = /^[a-zA-Z0-9@]*$/;
    var addressline1 = document.getElementById('txtPatientAddress').value;

    var city = document.getElementById('txtPatientcity').value;

    var state = document.getElementById('txtPatientstate').value;

    var zipcode = document.getElementById('txtPatientzip').value;

    var zipcode1 = /^[0-9]*$/;

    if (name1 == "") {
        alert("Please update the highlighted mandatory firstname field(s)");
        document.getElementById("txtPatientFname").style.borderColor = "#FF0000";
        document.getElementById("txtPatientFname").focus();
        return false;
    }
    else if (name1.length <= 5 || name1.length >= 50) {
        alert("FirstName should be in between 5 and 50");
        document.getElementById("txtPatientFname").style.borderColor = "#FF0000";
        document.getElementById("txtPatientFname").focus();
        return false;
    }
    else if (fname.test(name1) == false) {
        alert("FirstName should be an Alphabet");
        document.getElementById("txtPatientFname").style.borderColor = "#FF0000";
        document.getElementById("txtPatientFname").focus();
        return false;
    }
    else if (name2 == "") {
        alert("Please update the highlighted mandatory lastname field(s)");
        document.getElementById("txtPatientLname").style.borderColor = "#FF0000";
        document.getElementById("txtPatientLname").focus();
        return false;
    }
    else if (name2.length <= 5 || name2.length >= 50) {
        alert("LastName should be in between 5 and 50");
        document.getElementById("txtPatientLname").style.borderColor = "#FF0000";
        document.getElementById("txtPatientLname").focus();
        return false;
    }
    else if (lname.test(name2) == false) {
        alert("LastName should be an Alphabet");
        document.getElementById("txtPatientLname").style.borderColor = "#FF0000";
        document.getElementById("txtPatientLname").focus();
        return false;
    }
    else if (age == "") {
        alert("Please update the highlighted mandatory age field(s)");
        document.getElementById("txtPatientAge").style.borderColor = "#FF0000";
        document.getElementById("txtPatientAge").focus();
        return false;
    }
    else if (age1.test(age) == false) {
        alert("Please enter a valid age");
        document.getElementById("txtPatientAge").style.borderColor = "#FF0000";
        document.getElementById("txtPatientAge").focus();
        return false;
    }
    else if (age <= 1 || age >= 110) {
        alert("Please enter a valid age");
        document.getElementById("txtPatientAge").style.borderColor = "#FF0000";
        document.getElementById("txtPatientAge").focus();
        return false;
    }
    else if (select == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("ddlPatientGender").style.borderColor = "#FF0000";
        document.getElementById("ddlPatientGender").focus();
        return false;
    }

    else if (dob == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("txtPatientdob").style.borderColor = "#FF0000";
        document.getElementById("txtPatientdob").focus();
        return false;

    }
    else if (contact == "") {
        alert("Please update the highlighted mandatory contact field(s)");
        document.getElementById("txtPatientcntct").style.borderColor = "#FF0000";
        document.getElementById("txtPatientcntct").focus();
        return false;
    }
    else if (contact.length != 10 || contact1.test(contact) == false) {
        alert("contact number should be only valid number");
        document.getElementById("txtPatientcntct").style.borderColor = "#FF0000";
        document.getElementById("txtPatientcntct").focus();
        return false;
    }
    else if (email == "") {
        alert("Please update the highlighted mandatory email field(s)");
        document.getElementById("txtPatientEmail").style.borderColor = "#FF0000";
        document.getElementById("txtPatientEmail").focus();
        return false;
    }

    else if (email_Pattern.test(email) == false) {
        alert("Email should be of correct format");
        document.getElementById("txtPatientEmail").style.borderColor = "#FF0000";
        document.getElementById("txtPatientEmail").focus();
        return false;
    }
    else if (username == "") {
        alert("Please update the highlighted mandatory UserName field(s)");
        document.getElementById("txtPatientUserName").style.borderColor = "#FF0000";
        document.getElementById("txtPatientUserName").focus();
        return false;
    }
    else if (username.length < 5 || username.length > 15) {
        alert("User Name should be in between 5 and 15");
        document.getElementById("txtPatientUserName").style.borderColor = "#FF0000";
        document.getElementById("txtPatientUserName").focus();


        return false;
    }
    //else if (uname.test(username) == false) {
    //    alert("UserName should be an Alphabet");
    //    document.getElementById("txtPatientPasswd").style.borderColor = "#FF0000";
    //    document.getElementById("txtPatientPasswd").focus();
    //    return false;
    //}

    else if (password == "") {
        alert("Please update the highlighted mandatory password field(s)");
        document.getElementById("txtPatientPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtPatientPasswd").focus();
        return false;
    }
    else if (password.length < 8 || password.length > 15) {
        alert("Give strong password");
        document.getElementById("txtPatientPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtPatientPasswd").focus();

        return false;
    }
    else if (addressline1 == "") {
        alert("Please update the highlighted mandatory address field(s)");
        document.getElementById("txtPatientAddress").style.borderColor = "#FF0000";
        document.getElementById("txtPatientAddress").focus();
        return false;
    }
    else if (addressline1.length < 2 || addressline1.length > 100) {
        alert("Address should be between 2 to 100 characters");
        document.getElementById("txtPatientAddress").style.borderColor = "#FF0000";
        document.getElementById("txtPatientAddress").focus();
        return false;
    }
    else if (city == "") {
        alert("Please update the highlighted mandatory city field(s)");
        document.getElementById("txtPatientcity").style.borderColor = "#FF0000";
        document.getElementById("txtPatientcity").focus();
        return false;
    }
    else if (city.length <= 3 || city.length >= 50) {
        alert("city should be in between 3 and 50");
        document.getElementById("txtPatientcity").style.borderColor = "#FF0000";
        document.getElementById("txtPatientcity").focus();
        return false;
    }

    else if (state == "") {
        alert("Please update the highlighted mandatory state field(s)");
        document.getElementById("txtPatientstate").style.borderColor = "#FF0000";
        document.getElementById("txtPatientstate").focus();
        return false;
    }
    else if (state.length <= 3 || state.length >= 50) {
        alert("state should be in between 3 and 50");
        document.getElementById("txtPatientstate").style.borderColor = "#FF0000";
        document.getElementById("txtPatientstate").focus();
        return false;
    }
    else if (zipcode == "") {
        alert("Please update the highlighted mandatory zipcpde field(s)");
        document.getElementById("txtPatientzip").style.borderColor = "#FF0000";
        document.getElementById("txtPatientzip").focus();
        return false;
    }
    else if (zipcode1.test(zipcode) == false) {

        alert("ZipCode should be valid number");
        document.getElementById("txtPatientzip").style.borderColor = "#FF0000";
        document.getElementById("txtPatientzip").focus();
        return false;
    }
}


//----------------------Agent Validation-------------------------

function agent_validate() {

    var name1 = document.getElementById('txtAgentFname').value;
    var fname = /^[a-zA-Z]*$/;

    var name2 = document.getElementById('txtAgentLname').value;
    var lname = /^[a-zA-Z]*$/;

    var age = document.getElementById('txtAgentAge').value;
    var age1 = /^[0-9]*$/;

    var select = document.getElementById('ddlAgentGender').value;
   

    var dob = document.getElementById('txtAgentdob').value;
    var date = /^\d{2}[./-]\d{2}[./-]\d{4}$/;
    var contact = document.getElementById('txtAgentcntct').value;
    var contact1 = /^[0-9]*$/;

    var email_Pattern = /^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$/;
    var email = document.getElementById('txtAgentEmail').value;

    var username = document.getElementById('txtAgentUserName').value;
    var uname = /^[a-zA-Z0-9@]*$/;

    var password = document.getElementById('txtAgentPasswd').value;

    var addressline = /^[a-zA-Z0-9@]*$/;
    var addressline1 = document.getElementById('txtAgentAddress').value;

    var city = document.getElementById('txtAgentcity').value;

    var state = document.getElementById('txtAgentstate').value;

    var zipcode = document.getElementById('txtAgentzip').value;

    var zipcode1 = /^[0-9]*$/;

    if (name1 == "") {
        alert("Please update the highlighted mandatory firstname field(s)");
        document.getElementById("txtAgentFname").style.borderColor = "#FF0000";
        document.getElementById("txtAgentFname").focus();

        return false;
    }
    else if (name1.length <= 5 || name1.length >= 50) {
        alert("FirstName should be in between 5 and 50");
        document.getElementById("txtAgentFname").style.borderColor = "#FF0000";
        document.getElementById("txtAgentFname").focus();
        return false;
    }
    else if (fname.test(name1) == false) {
        alert("FirstName should be an Alphabet");
        document.getElementById("txtAgentFname").style.borderColor = "#FF0000";
        document.getElementById("txtAgentFname").focus();
        return false;
    }
    else if (name2 == "") {
        alert("Please update the highlighted mandatory lastname field(s)");
        document.getElementById("txtAgentLname").style.borderColor = "#FF0000";
        document.getElementById("txtAgentLname").focus();
        return false;
    }
    else if (name2.length <= 5 || name2.length >= 50) {
        alert("LastName should be in between 5 and 50");
        document.getElementById("txtAgentLname").style.borderColor = "#FF0000";
        document.getElementById("txtAgentLname").focus();
        return false;
    }
    else if (lname.test(name2) == false) {
        alert("LastName should be an Alphabet");
        document.getElementById("txtAgentLname").style.borderColor = "#FF0000";
        document.getElementById("txtAgentLname").focus();
        return false;
    }
    else if (age == "") {
        alert("Please update the highlighted mandatory age field(s)");
        document.getElementById("txtAgentAge").style.borderColor = "#FF0000";
        document.getElementById("txtAgentAge").focus();
        return false;
    }
    else if (age1.test(age) == false) {
        alert("Please enter a valid age");
        document.getElementById("txtAgentAge").style.borderColor = "#FF0000";
        document.getElementById("txtAgentAge").focus();
        return false;
    }
    else if (age <= 1 || age >= 110) {
        alert("Please enter a valid age");
        document.getElementById("txtAgentAge").style.borderColor = "#FF0000";
        document.getElementById("txtAgentAge").focus();
        return false;
    }
    else if (select == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("ddlAgentGender").style.borderColor = "#FF0000";
        document.getElementById("ddlAgentGender").focus();
        return false;
    }

  
    else if (date == "") {
        alert("Please update the highlighted mandatory select field(s)");
        document.getElementById("txtAgentdob").style.borderColor = "#FF0000";
        document.getElementById("txtAgentdob").focus();
        return false;

    }
    else if (contact == "") {
        alert("Please update the highlighted mandatory contact field(s)");
        document.getElementById("txtAgentcntct").style.borderColor = "#FF0000";

        document.getElementById("txtAgentcntct").focus();
        return false;
    }
    else if (contact.length != 10 || contact1.test(contact) == false) {
        alert("contact number should be only valid number");
        document.getElementById("txtAgentcntct").style.borderColor = "#FF0000";
        document.getElementById("txtAgentcntct").focus();
        return false;
    }
    else if (email == "") {
        alert("Please update the highlighted mandatory email field(s)");
        document.getElementById("txtAgentEmail").style.borderColor = "#FF0000";
        document.getElementById("txtAgentEmail").focus();
        return false;
    }

    else if (email_Pattern.test(email) == false) {
        alert("Email should be of correct format");
        document.getElementById("txtAgentEmail").style.borderColor = "#FF0000";
        document.getElementById("txtAgentEmail").focus();
        return false;
    }
    else if (username == "") {
        alert("Please update the highlighted mandatory user name field(s)");
        document.getElementById("txtAgentUserName").style.borderColor = "#FF0000";
        document.getElementById("txtAgentUserName").focus();
        return false;
    }
    else if (username.length < 5 || username.length > 15) {
        alert("User Name Should be in between 5 and 15");
        document.getElementById("txtAgentUserName").style.borderColor = "#FF0000";
        document.getElementById("txtAgentUserName").focus();

        return false;
    }
    //else if (uname.test(username) == false) {
    //    alert("UserName should be an Alphabet");
    //    document.getElementById("txtAgentUserName").style.borderColor = "#FF0000";
    //    document.getElementById("txtAgentUserName").focus();
    //    return false;
    //}

    else if (password == "") {
        alert("Please update the highlighted mandatory password field(s)");
        document.getElementById("txtAgentPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtAgentPasswd").focus();
        return false;
    }
    else if (password.length < 8 || password.length > 15) {
        alert("Give strong password");
        document.getElementById("txtAgentPasswd").style.borderColor = "#FF0000";
        document.getElementById("txtAgentPasswd").focus();

        return false;
    }
    else if (addressline1 == "") {
        alert("Please update the highlighted mandatory address field(s)");
        document.getElementById("txtAgentAddress").style.borderColor = "#FF0000";
        document.getElementById("txtAgentAddress").focus();
        return false;
    }
    else if (addressline1.length < 2 || addressline1.length > 100) {
        alert("Address should be between 2 to 100 characters");
        document.getElementById("txtAgentAddress").style.borderColor = "#FF0000";
        document.getElementById("txtAgentAddress").focus();
        return false;
    }
    else if (city == "") {
        alert("Please update the highlighted mandatory city field(s)");
        document.getElementById("txtAgentcity").style.borderColor = "#FF0000";
        document.getElementById("txtAgentcity").focus();
        return false;
    }
    else if (city.length <= 3 || city.length >= 50) {
        alert("city should be in between 3 and 50");
        document.getElementById("txtAgentcity").style.borderColor = "#FF0000";
        document.getElementById("txtAgentcity").focus();
        return false;
    }

    else if (state == "") {
        alert("Please update the highlighted mandatory state field(s)");
        document.getElementById("txtAgentstate").style.borderColor = "#FF0000";
        document.getElementById("txtAgentstate").focus();
        return false;
    }
    else if (state.length <= 3 || state.length >= 50) {
        alert("state should be in between 3 and 50");
        document.getElementById("txtAgentstate").style.borderColor = "#FF0000";
        document.getElementById("txtAgentstate").focus();
        return false;
    }
    else if (zipcode == "") {
        alert("Please update the highlighted mandatory zipcpde field(s)");
        document.getElementById("txtAgentzip").style.borderColor = "#FF0000";
        document.getElementById("txtAgentzip").focus();
        return false;
    }
    else if (zipcode1.test(zipcode) == false) {

        alert("ZipCode should be valid number");
        document.getElementById("txtAgentzip").style.borderColor = "#FF0000";
        document.getElementById("txtAgentzip").focus();
        return false;
    }
}
//--------------------add services------
function service_validate()
{
    //alert("0fyjtf");
    var medicareservice = document.getElementById("txtMS").value;
    var mservice = /^[a-zA-Z ]*$/;
    var servicedescription = document.getElementById("txtMSDescription").value;
    var amount = document.getElementById("txtAmount").value;
    var num = /^[0-9]*$/;
    if (medicareservice == "") {
        alert("Please update the highlighted mandatory medicare service field(s)");
        document.getElementById("txtMS").style.borderColor = "#FF0000";
        document.getElementById("txtMS").focus();

        return false;
    }
    else if (mservice.length <= 5 || mservice.length >= 50) {
        alert("medicare service should be in between 5 and 50");
        document.getElementById("mservice").style.borderColor = "#FF0000";
        document.getElementById("mservice").focus();
        return false;
    }
    else if (mservice.test(medicareservice) == false) {
        alert("medicare service  should be an Alphabet");
        document.getElementById("mservice").style.borderColor = "#FF0000";
        document.getElementById("mservice").focus();
        return false;
    }
   else if (servicedescription == "") {
        alert("Please update the highlighted mandatory service description field(s)");
        document.getElementById("txtMSDescription").style.borderColor = "#FF0000";
        document.getElementById("txtMSDescription").focus();

        return false;
    }
   else if (mservice.test(servicedescription) == false) {
        alert(" service description  should be an Alphabet");
        document.getElementById("txtMSDescription").style.borderColor = "#FF0000";
        document.getElementById("txtMSDescription").focus();
        return false;
   }
   else if (amount == "") {
       alert("Please update the highlighted mandatory age field(s)");
       document.getElementById("txtAmount").style.borderColor = "#FF0000";
       document.getElementById("txtAmount").focus();
       return false;
   }
   else if (num.test(amount) == false) {
       alert("Please enter a valid amount");
       document.getElementById("txtAmount").style.borderColor = "#FF0000";
       document.getElementById("txtAmount").focus();
       return false;
   }

}
//--------------------testResult_Validation-------------------------
var medicareservice = document.getElementById("txtMS").value;
