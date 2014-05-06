using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebService
{
    public class DataAccessLayerWebService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        private DataTable ExecuteQuery(string sqlStr)
        {
            DataTable dataTable = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStr, con);
                dataAdapter.Fill(dataTable);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return dataTable;
        }

        public List<ObjectOwner> GetObjectOwner()
        {
            string sqlStr = "select * from ObjectOwner";           
            DataTable dt = ExecuteQuery(sqlStr);
            List<ObjectOwner> objectOwnerList = new List<ObjectOwner>();

            foreach (DataRow dataRow in dt.Rows)
            {
                ObjectOwner oo = new ObjectOwner();
                oo.OwnerSsnr = dataRow["ownerSsnrs"].ToString();
                oo.Name = dataRow["name"].ToString();
                oo.PhoneNr = dataRow["phoneNr"].ToString();
                oo.Email = dataRow["email"].ToString();
                objectOwnerList.Add(oo);
            }
            return objectOwnerList;
        }

        public List<RealEstateBroker> GetRealEstateBroker()
        {
            string sqlStr = "select * from RealEstateBroker";
            DataTable dt = ExecuteQuery(sqlStr);

            List<RealEstateBroker> RealEstateBrokerList = new List<RealEstateBroker>();

            foreach (DataRow dataRow in dt.Rows)
            {
                RealEstateBroker oo = new RealEstateBroker();
                oo.BrokerSsnr = dataRow["brokerSsnr"].ToString();
                oo.Name = dataRow["name"].ToString();
                oo.PhoneNr = dataRow["phoneNr"].ToString();
                oo.Email = dataRow["email"].ToString();
                oo.City = dataRow["city"].ToString();
                oo.BrokerAddress = dataRow["brokerAddress"].ToString();
                RealEstateBrokerList.Add(oo);
            }

            return RealEstateBrokerList;
        }

        public List<Showing> GetShowing()
        {
            string sqlStr = "select * from Showing";
            DataTable dt = ExecuteQuery(sqlStr);
            List<Showing> ShowingList = new List<Showing>();

            foreach (DataRow dataRow in dt.Rows)
            {
                Showing s = new Showing();
                s.BuyerSsnr = dataRow["buyerSsnr"].ToString();
                s.ObjNr = int.Parse(dataRow["objNr"].ToString());
                s.ShowingDate = dataRow["showingDate"].ToString();
                ShowingList.Add(s);
            }

            return ShowingList;
        }

        public List<ProspectiveBuyer> GetProspectiveBuyers()
        {
            string sqlStr = "select * from ProspectiveBuyer";
            DataTable dt = ExecuteQuery(sqlStr);
            List<ProspectiveBuyer> prospectiveBuyerList = new List<ProspectiveBuyer>();

            foreach (DataRow dataRow in dt.Rows)
            {
                ProspectiveBuyer pb = new ProspectiveBuyer();
                pb.BuyerSsnr = dataRow["buyerSsnr"].ToString();
                pb.Name = dataRow["name"].ToString();
                pb.PhoneNr = dataRow["phoneNr"].ToString();
                pb.Email = dataRow["email"].ToString();
                prospectiveBuyerList.Add(pb);
            }

            return prospectiveBuyerList;
        }

        public List<RealEstateObject> GetRealEstateObjects()
        {
            string sqlStr = "select * from RealEstateObject";
            DataTable dt = ExecuteQuery(sqlStr);
            List<RealEstateObject> realEstateObjectList = new List<RealEstateObject>();

            foreach (DataRow dataRow in dt.Rows)
            {
                RealEstateObject ro = new RealEstateObject();
                ro.Objnr = int.Parse(dataRow["objNr"].ToString());
                ro.ObjAddress = dataRow["objAddress"].ToString();
                ro.ObjCity = dataRow["objCity"].ToString();
                ro.ObjArea = int.Parse(dataRow["objArea"].ToString());
                ro.ObjInfo = dataRow["objInfo"].ToString();
                ro.ObjPrice = int.Parse(dataRow["objPrice"].ToString());
                ro.OwnerSsnr = dataRow["ownerSsnr"].ToString();
                ro.UnitType = dataRow["objUnitType"].ToString();
                ro.Image = dataRow["objImage"].ToString();
                ro.BrokerSsnr = dataRow["brokerSsnr"].ToString();
                ro.ObjRooms = dataRow["objRooms"].ToString();
                realEstateObjectList.Add(ro);
            }

            return realEstateObjectList;

        }
    }
}