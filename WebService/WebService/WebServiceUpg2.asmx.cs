using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WebService
{
    /// <summary>
    /// Summary description for WebServiceUpg2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUpg2 : System.Web.Services.WebService
    {
        string connectionString = "server=localhost; Trusted_Connection=yes; database=MA Praktikfallet;";

        [WebMethod(Description = "Returns ObjectOwners", EnableSession = false)]

        public List<ObjectOwner> GetObjectOwner()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select * from ObjectOwner", connectionString);

            DataSet objectOwnerDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(objectOwnerDS, "ObjectOwner");

            DataTable dt = new DataTable();
            dt = objectOwnerDS.Tables["ObjectOwner"];
            List<ObjectOwner> objectOwnerList = new List<ObjectOwner>();


            foreach (DataRow dataRow in dt.Rows)
            {
                ObjectOwner oo = new ObjectOwner();
                oo.OwnerSsnr = dataRow["ownerSsnr"].ToString();
                oo.Name = dataRow["name"].ToString();
                oo.PhoneNr = dataRow["phoneNr"].ToString();
                oo.Email = dataRow["email"].ToString();
                objectOwnerList.Add(oo);
            }


            return objectOwnerList;

        }

        [WebMethod(Description = "Returns RealEstateBroker", EnableSession = false)]

        public List<RealEstateBroker> GetRealEstateBroker()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select * from RealEstateBroker", connectionString);
            DataSet realEstateBrokerDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(realEstateBrokerDS, "RealEstateBroker");

            DataTable dt = new DataTable();
            dt = realEstateBrokerDS.Tables["RealEstateBroker"];
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

        [WebMethod(Description = "Returns Showings", EnableSession = false)]

        public List<Showing> GetShowing()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select * from Showing", connectionString);
            DataSet showingDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(showingDS, "Showing");

            DataTable dt = new DataTable();
            dt = showingDS.Tables["Showing"];
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

        [WebMethod(Description = "Returns ProspectiveBuyers", EnableSession = false)]

        public List<ProspectiveBuyer> GetProspectiveBuyers()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select * from ProspectiveBuyer", connectionString);
            DataSet prospectiveBuyerDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(prospectiveBuyerDS, "ProspectiveBuyer");

            DataTable dt = new DataTable();
            dt = prospectiveBuyerDS.Tables["ProspectiveBuyer"];
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

        [WebMethod(Description = "Returns RealEstateObjects", EnableSession = false)]

        public List<RealEstateObject> GetRealEstateObjects()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select * from RealEstateObject", connectionString);
            DataSet realEstateObjectDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(realEstateObjectDS, "RealEstateObject");

            DataTable dt = new DataTable();
            dt = realEstateObjectDS.Tables["RealEstateObject"];
            List<RealEstateObject> realEstateObjectList = new List<RealEstateObject>();


            foreach (DataRow dataRow in dt.Rows)
            {
                RealEstateObject ro = new RealEstateObject();
                ro.Objnr = int.Parse(dataRow["objNr"].ToString());
                ro.ObjAddress = dataRow["objAddress"].ToString();
                ro.ObjArea = int.Parse(dataRow["objArea"].ToString());
                ro.ObjInfo = dataRow["objInfo"].ToString();
                ro.ObjPrice = int.Parse(dataRow["objPrice"].ToString());
                ro.OwnerSsnr = dataRow["ownerSsnr"].ToString();
                ro.UnitType = dataRow["objUnitType"].ToString();
                ro.Image = dataRow["objImage"].ToString();
                ro.BrokerSsnr = dataRow["brokerSsnr"].ToString();
                ro.ObjRooms = dataRow["objRooms"].ToString();
                ro.ObjCity = dataRow["objCity"].ToString();
                realEstateObjectList.Add(ro);
            }


            return realEstateObjectList;

        }
    }
}

