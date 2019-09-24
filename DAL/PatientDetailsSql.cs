﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class PatientDetailsSql : IPatientDetails
    {
        public List<PatientDetails> DisplayPatientDetails()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "select * from Patient";
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            DataTable _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            List<PatientDetails> patientDetails = new List<PatientDetails>();
            if (_dataTable.Rows.Count > 0)
            {
                foreach (DataRow _dataRow in _dataTable.Rows)
                {
                    patientDetails.Add(new PatientDetails
                        (
                        int.Parse(_dataRow["Patientid"].ToString()),
                        _dataRow["FirstName"].ToString(),
                        _dataRow["LastName"].ToString(),
                        int.Parse(_dataRow["Age"].ToString()),
                        _dataRow["Gender"].ToString(),
                        _dataRow["DoB"].ToString(),
                        double.Parse(_dataRow["ContactNumber"].ToString()),
                         double.Parse(_dataRow["AltContactNumber"].ToString()),
                         _dataRow["EmailID"].ToString(),
                         _dataRow["UserName"].ToString(),
                         _dataRow["Password"].ToString(),
                         _dataRow["AddressLine1"].ToString(),
                         _dataRow["AddressLine2"].ToString(),
                         _dataRow["City"].ToString(),
                         _dataRow["State"].ToString(),
                         int.Parse(_dataRow["Zipcode"].ToString())                         
                        //_dataRow["Isapproved"].ToString() == "Yes" ? true : false,
                        //DateTime.Parse(_dataRow["Isapproved_On"].ToString())

                        ));
                }
                return patientDetails;
            }
            else
            {
                return new List<PatientDetails>();
            }
        }

        public void RemovePatient(string name)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "delete  from Patient where FirstName=@patientname";
            _sqlCommand.Parameters.AddWithValue("@patientname", name);
            int res = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void ModifyPatientDetails()
        {
            throw new NotImplementedException();
        }

        public void RegPatientDetails(PatientDetails patientDetails)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand("Registerpatientdetails", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.Parameters.AddWithValue("@Firstname", patientDetails.FirstName1);
            _sqlCommand.Parameters.AddWithValue("@Lastname", patientDetails.LastName1);
            _sqlCommand.Parameters.AddWithValue("@Age", patientDetails.Age1);
            _sqlCommand.Parameters.AddWithValue("@Gender", patientDetails.Gender1);
            _sqlCommand.Parameters.AddWithValue("@DoB", patientDetails.DoB1);
            _sqlCommand.Parameters.AddWithValue("@ContactNumber", patientDetails.ContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@AltContactNumber", patientDetails.AltContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@Emailid", patientDetails.EmailId1);
            _sqlCommand.Parameters.AddWithValue("@UserName", patientDetails.UserName1);
            _sqlCommand.Parameters.AddWithValue("@Password", patientDetails.Password1);
            _sqlCommand.Parameters.AddWithValue("@AddressLine1", patientDetails.AddressLine11);
            _sqlCommand.Parameters.AddWithValue("@AddressLine2", patientDetails.AddressLine21);
            _sqlCommand.Parameters.AddWithValue("@City", patientDetails.City1);
            _sqlCommand.Parameters.AddWithValue("@State", patientDetails.State1);
            _sqlCommand.Parameters.AddWithValue("@Zipcode", patientDetails.Zipcode1);

            //_sqlCommand.Parameters.AddWithValue("@Isapproved", doctorDetails.Isapproved1);
            //_sqlCommand.Parameters.AddWithValue("@IsApprovedOn", doctorDetails.Isapproved_On1);
            int result = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }
    }
}