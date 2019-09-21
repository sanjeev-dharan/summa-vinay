using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AdminDetails
    {
        int AdminId;
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
        //bool Isapproved;
        //DateTime Isapproved_On;

        public int AdminId1
        {
            get
            {
                return AdminId;
            }

            set
            {
                AdminId = value;
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

        //public bool Isapproved1
        //{
        //    get
        //    {
        //        return Isapproved;
        //    }

        //    set
        //    {
        //        Isapproved = value;
        //    }
        //}

        //public DateTime Isapproved_On1
        //{
        //    get
        //    {
        //        return Isapproved_On;
        //    }

        //    set
        //    {
        //        Isapproved_On = value;
        //    }
        //}

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

        public AdminDetails()
        {

        }
        public AdminDetails(int AdminId, string FirstName, string LastName, int Age, string Gender, string DoB, double ContactNumber, double AltContactNumber, string EmailId,string UserName, string Password)
        {
            this.AdminId = AdminId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Gender = Gender;
            this.DoB = DoB;
            this.ContactNumber = ContactNumber;
            this.AltContactNumber = AltContactNumber;
            this.EmailId = EmailId;
            this.UserName = UserName;
            this.Password = Password;
            //this.Isapproved = Isapproved;
            //this.Isapproved_On = Isapproved_On;
            //, bool Isapproved, DateTime Isapproved_On
        }

    }
}
