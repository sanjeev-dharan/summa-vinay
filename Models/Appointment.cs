using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class Appointment
    {
        string appointmentdate;
        int medicareserviceid;
        bool Isapproved;
        int doctorid;
        public string Appointmentdate
        {
            get
            {
                return appointmentdate;
            }

            set
            {
                appointmentdate = value;
            }
        }

        public int Medicareserviceid
        {
            get
            {
                return medicareserviceid;
            }

            set
            {
                medicareserviceid = value;
            }
        }

        public bool Isapproved1
        {
            get
            {
                return Isapproved;
            }

            set
            {
                Isapproved = value;
            }
        }

        public int Doctorid
        {
            get
            {
                return doctorid;
            }

            set
            {
                doctorid = value;
            }
        }

        public Appointment()
        {

        }
        public Appointment(string appointmentdate,int medicareserviceid,bool Isapproved)
        {
            this.appointmentdate = appointmentdate;
            this.medicareserviceid = medicareserviceid;
            this.Isapproved=Isapproved;
        }
        



        }
    }

