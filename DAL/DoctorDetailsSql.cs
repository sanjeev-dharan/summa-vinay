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
    public class DoctorDetailsSql : IDoctorDetails
    {
        public List<DoctorDetails> DisplayDoctorDetails()
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "select * from Doctor";
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            DataTable _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            List<DoctorDetails> doctorDetails = new List<DoctorDetails>();
            if (_dataTable.Rows.Count > 0)
            {
                foreach (DataRow _dataRow in _dataTable.Rows)
                {
                    doctorDetails.Add(new DoctorDetails
                        (
                        int.Parse(_dataRow["DoctorID"].ToString()),
                        _dataRow["FirstName"].ToString(),
                        _dataRow["LastName"].ToString(),
                        int.Parse(_dataRow["Age"].ToString()),
                        _dataRow["Gender"].ToString(),
                        _dataRow["DoB"].ToString(),
                        double.Parse(_dataRow["ContactNumber"].ToString()),
                         double.Parse(_dataRow["AltContactNumber"].ToString()),
                         _dataRow["EmailId"].ToString(),
                         _dataRow["UserName"].ToString(),
                         _dataRow["Password"].ToString(),
                         _dataRow["AddressLine1"].ToString(),
                         _dataRow["AddressLine2"].ToString(),
                         _dataRow["City"].ToString(),
                         _dataRow["State"].ToString(),
                         int.Parse(_dataRow["Zipcode"].ToString()),
                         _dataRow["Degree"].ToString(),
                         _dataRow["Specialty"].ToString(),
                         int.Parse(_dataRow["Workhours"].ToString()),
                         _dataRow["HospitalName"].ToString(),
                          int.Parse(_dataRow["MedicareServiceID"].ToString())

                        //_dataRow["Isapproved"].ToString() == "Yes" ? true : false,
                        //DateTime.Parse(_dataRow["Isapproved_On"].ToString())

                        ));
                }
                return doctorDetails;
            }
            else
            {
                return new List<DoctorDetails>();
            }
        }

        public void  RemoveDoctor(string name)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "delete  from Doctor where FirstName=@doctorname";
            _sqlCommand.Parameters.AddWithValue("@doctorname",name);
            int res=_sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();



        }

        public void ModifyDoctorDetails()
        {
            throw new NotImplementedException();
        }

        public void RegDoctorDetails(DoctorDetails doctorDetails)
        {
            SqlConnection _sqlConnection = ConnectionHandler.GetConnection();
            _sqlConnection.Open();
            SqlCommand _sqlCommand = new SqlCommand("RegisterDoctordetails", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Connection = _sqlConnection;
            //_sqlCommand.CommandText = "insert into  Doctor(FirstName,LastName,Age,Gender,DoB,ContactNumber,AltContactNumber,EmailId,UserName,Password,AddressLine1,AddressLine2,City,State,Zipcode,Degree,Speciality,Workhours,HospitalName,MedicareServiceID) values(@Firstname,@Lastname,@Age,@Gender,@DoB,@ContactNumber,@AltContactNumber,@Emailid,@UserName,@Password,@AddressLine1,@AddressLine2,@City,@State,@Zipcode,@Degree,@Speciality,@Workhours,@HospitalName,@MedicareServiceID)";

            _sqlCommand.Parameters.AddWithValue("@FirstName", doctorDetails.FirstName1);
            _sqlCommand.Parameters.AddWithValue("@LastName", doctorDetails.LastName1);
            _sqlCommand.Parameters.AddWithValue("@Age", doctorDetails.Age1);
            _sqlCommand.Parameters.AddWithValue("@Gender", doctorDetails.Gender1);
            _sqlCommand.Parameters.AddWithValue("@DoB", doctorDetails.DoB1);
            _sqlCommand.Parameters.AddWithValue("@ContactNumber", doctorDetails.ContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@AltContactNumber", doctorDetails.AltContactNumber1);
            _sqlCommand.Parameters.AddWithValue("@Emailid", doctorDetails.EmailID1);
            _sqlCommand.Parameters.AddWithValue("@UserName", doctorDetails.UserName1);
            _sqlCommand.Parameters.AddWithValue("@Password", doctorDetails.Password1);
            _sqlCommand.Parameters.AddWithValue("@AddressLine1", doctorDetails.AddressLine11);
            _sqlCommand.Parameters.AddWithValue("@AddressLine2", doctorDetails.AddressLine21);
            _sqlCommand.Parameters.AddWithValue("@City", doctorDetails.City1);
            _sqlCommand.Parameters.AddWithValue("@State", doctorDetails.State1);
            _sqlCommand.Parameters.AddWithValue("@Zipcode", doctorDetails.Zipcode1);
            _sqlCommand.Parameters.AddWithValue("@Degree", doctorDetails.Degree1);
            _sqlCommand.Parameters.AddWithValue("@Specialty", doctorDetails.Specialty1);
            _sqlCommand.Parameters.AddWithValue("@Workhours", doctorDetails.Workhours1);
            _sqlCommand.Parameters.AddWithValue("@HospitalName", doctorDetails.HospitalName1);
            _sqlCommand.Parameters.AddWithValue("@MedicareServiceID", doctorDetails.MedicareServiceID1);
            //_sqlCommand.Parameters.AddWithValue("@Isapproved", doctorDetails.Isapproved1);
            //_sqlCommand.Parameters.AddWithValue("@IsApprovedOn", doctorDetails.Isapproved_On1);
            
            int result1 = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        
    }
}