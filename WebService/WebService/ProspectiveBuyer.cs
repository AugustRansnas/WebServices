using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class ProspectiveBuyer
    {

        public ProspectiveBuyer() { }

        private string buyerSsnr;
        private string name; 
        private string email; 
        private string phoneNr;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public string PhoneNr
        {
            get { return phoneNr; }
            set { phoneNr = value; }
        }
       
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string BuyerSsnr
        {
            get { return buyerSsnr; }
            set { buyerSsnr = value; }
        }
       
    }
}