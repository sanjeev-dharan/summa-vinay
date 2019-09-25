using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class MedicareServices
    {

        int MedicareServicesId;
        string Medicare_service;
        string Service_Description;
        int Amount;
       

        public int MedicareServicesId1
        {
            get
            {
                return MedicareServicesId;
            }

            set
            {
                MedicareServicesId = value;
            }
        }

        public string Medicare_service1
        {
            get
            {
                return Medicare_service;
            }

            set
            {
                Medicare_service = value;
            }
        }

        public string Service_Description1
        {
            get
            {
                return Service_Description;
            }

            set
            {
                Service_Description = value;
            }
        }

        public int Amount1
        {
            get
            {
                return Amount;
            }

            set
            {
                Amount = value;
            }
        }



        public MedicareServices()
        {

        }
   
        public MedicareServices(int MedicareServicesId,string Medicare_service,string Service_Description,int Amount)
        {
            this.MedicareServicesId = MedicareServicesId;
            this.Medicare_service = Medicare_service;
            this.Service_Description = Service_Description;
            this.Amount = Amount;
        
          
        }
    }
}
