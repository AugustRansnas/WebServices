using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Showing
    {
        private int objNr;
        private string buyerSsnr;
        private string showingDate;

        public Showing() { }

        public int ObjNr
        {
            get { return objNr; }
            set { objNr = value; }
        }
        

        public string BuyerSsnr
        {
            get { return buyerSsnr; }
            set { buyerSsnr = value; }
        }
        

        public string ShowingDate
        {
            get { return showingDate; }
            set { showingDate = value; }
        }




    }
}