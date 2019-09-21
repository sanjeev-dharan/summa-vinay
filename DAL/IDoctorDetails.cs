using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDoctorDetails
    {
        void  RegDoctorDetails(DoctorDetails doctorDetails);
        List<DoctorDetails> DisplayDoctorDetails();
        void ModifyDoctorDetails();
        void RemoveDoctor(string Doctorname);
    }
}
