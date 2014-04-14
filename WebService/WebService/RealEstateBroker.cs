using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class RealEstateBroker
    {
        private string brokerSsnr;
        private string name;
        private string brokerAddress;
        private string city;
        private string phoneNr;


        public RealEstateBroker()
        {}

        public string BrokerSsnr
        {
            get { return brokerSsnr; }
            set { brokerSsnr = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public string BrokerAddress
        {
            get { return brokerAddress; }
            set { brokerAddress = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }
        

        public string PhoneNr
        {
            get { return phoneNr; }
            set { phoneNr = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}