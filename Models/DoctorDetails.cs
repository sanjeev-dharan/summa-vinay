using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class DoctorDetails
    {
        int DoctorID;
        string FirstName;
        string LastName;
        int Age;
        string Gender;
        string DoB;
        double ContactNumber;
        double AltContactNumber;
        string EmailID;
        string UserName;
        string Password;
        string AddressLine1;
        string AddressLine2;
        string City;
        string State;
        int Zipcode;
        string Degree;
        string Specialty;
        int Workhours;
        string HospitalName;
        int MedicareServiceID;
       

        public int DoctorID1
        {
            get
            {
                return DoctorID;
            }

            set
            {
                DoctorID = value;
            }
        }

        public string FirstName1
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string LastName1
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public int Age1
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        public string Gender1
        {
            get
            {
                return Gender;
            }

            set
            {
                Gender = value;
            }
        }

        public string DoB1
        {
            get
            {
                return DoB;
            }

            set
            {
                DoB = value;
            }
        }

        public double ContactNumber1
        {
            get
            {
                return ContactNumber;
            }

            set
            {
                ContactNumber = value;
            }
        }

        public double AltContactNumber1
        {
            get
            {
                return AltContactNumber;
            }

            set
            {
                AltContactNumber = value;
            }
        }

        public string EmailID1
        {
            get
            {
                return EmailID;
            }

            set
            {
                EmailID = value;
            }
        }

        public string Password1
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }

        public string AddressLine11
        {
            get
            {
                return AddressLine1;
            }

            set
            {
                AddressLine1 = value;
            }
        }

        public string AddressLine21
        {
            get
            {
                return AddressLine2;
            }

            set
            {
                AddressLine2 = value;
            }
        }

        public string City1
        {
            get
            {
                return City;
            }

            set
            {
                City = value;
            }
        }

        public string State1
        {
            get
            {
                return State;
            }

            set
            {
                State = value;
            }
        }

        public int Zipcode1
        {
            get
            {
                return Zipcode;
            }

            set
            {
                Zipcode = value;
            }
        }

        public string Degree1
        {
            get
            {
                return Degree;
            }

            set
            {
                Degree = value;
            }
        }

        public string Specialty1
        {
            get
            {
                return Specialty;
            }

            set
            {
                Specialty = value;
            }
        }

        public int Workhours1
        {
            get
            {
                return Workhours;
            }

            set
            {
                Workhours = value;
            }
        }

        public string HospitalName1
        {
            get
            {
                return HospitalName;
            }

            set
            {
                HospitalName = value;
            }
        }

        public int MedicareServiceID1
        {
            get
            {
                return MedicareServiceID;
            }

            set
            {
                MedicareServiceID = value;
            }
        }

      

        public string UserName1
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }

        public DoctorDetails()
        {

        }
        public DoctorDetails(int DoctorID,string FirstName,string LastName,int Age,string Gender,string DoB,double ContactNumber,
        double AltContactNumber,string EmailID, string UserName,string Password,string AddressLine1,string AddressLine2,string City,string State,
        int Zipcode,string Degree,string Specialty,int Workhours,string HospitalName,int MedicareServiceID)
        {
            this.DoctorID = DoctorID;
            this.FirstName = FirstName;
            this.Age = Age;
            this.Gender = Gender;
            this.DoB = DoB;
            this.ContactNumber = ContactNumber;
            this.AltContactNumber = AltContactNumber;
            this.EmailID = EmailID;
            this.UserName = UserName;
            this.Password = Password;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.Degree = Degree;
            this.Specialty = Specialty;
            this.Workhours = Workhours;
            this.HospitalName = HospitalName;
            this.MedicareServiceID = MedicareServiceID;
          

        }

    }
    
}
