using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class RealEstateObject
    {
        private int objnr;
        private string objCity;
        private int objPrice; 
        private int objArea;
        private string objAddress;
        private string objRooms;
        private string unitType;
        private string objInfo;
        private string brokerSsnr;
        private string ownerSsnr;
        private string image;
        //
        public string Image
        {
            get { return image; }
            set { image = value; }
        } 

        public RealEstateObject() { }


        public int Objnr
        {
            get { return objnr; }
            set { objnr = value; }
        }

        public string ObjAddress
        {
            get { return objAddress; }
            set { objAddress = value; }
        }

        public string ObjCity
        {
            get { return objCity; }
            set { objCity = value; }
        }
        
        public int ObjPrice
        {
            get { return objPrice; }
            set { objPrice = value; }
        }
       
        public int ObjArea
        {
            get { return objArea; }
            set { objArea = value; }
        }
        
        public string ObjRooms
        {
            get { return objRooms; }
            set { objRooms = value; }
        }
        
        public string UnitType
        {
            get { return unitType; }
            set { unitType = value; }
        }

        public string ObjInfo
        {
            get { return objInfo; }
            set { objInfo = value; }
        }

         public string BrokerSsnr
        {
            get { return brokerSsnr; }
            set { brokerSsnr = value; }
        }

        public string OwnerSsnr
        {
            get { return ownerSsnr; }
            set { ownerSsnr = value; }
        } 
        
    }
}