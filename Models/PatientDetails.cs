using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class PatientDetails
    {
        int Patientid;
        string FirstName;
        string LastName;
        int Age;
        string Gender;
        string DoB;
        double ContactNumber;
        double AltContactNumber;
        string EmailId;
        string UserName;
        string Password;
        string AddressLine1;
        string AddressLine2;
        string City;
        string State;
        int Zipcode;


        public int Patientid1
        {
            get
            {
                return Patientid;
            }

            set
            {
                Patientid = value;
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

        public string EmailId1
        {
            get
            {
                return EmailId;
            }

            set
            {
                EmailId = value;
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

        public PatientDetails()
        {

        }
        public PatientDetails(int Patientid, string FirstName, string LastName, int Age, string Gender, string DoB, double ContactNumber,
        double AltContactNumber, string EmailId, string UserName, string Password, string AddressLine1, string AddressLine2, string City, string State,
        int Zipcode)
        {
            this.Patientid = Patientid;
            this.FirstName = FirstName;
            this.Age = Age;
            this.Gender = Gender;
            this.DoB = DoB;
            this.ContactNumber = ContactNumber;
            this.AltContactNumber = AltContactNumber;
            this.EmailId = EmailId;
            this.UserName = UserName;
            this.Password = Password;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
       


        }
    }
}
