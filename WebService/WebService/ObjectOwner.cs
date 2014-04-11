using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class ObjectOwner
    {
        private string ownerSsnr;
        private string name;
        private string phoneNr;
        private string email;

        public ObjectOwner() { }

        public ObjectOwner(string ownerSsnr, string name, string phoneNr,string email) 
        {
            OwnerSsnr = this.ownerSsnr;
            Name = this.name;
            PhoneNr = this.phoneNr;
            Email = this.email;
        }

        public string OwnerSsnr
        {
            get { return ownerSsnr; }
            set { ownerSsnr = value; }
        }

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
    }
}