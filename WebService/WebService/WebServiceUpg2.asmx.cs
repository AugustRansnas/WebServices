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
        string connectionString = "server=localhost; Trusted_Connection=yes; database=PK Praktikfallet;";

        [WebMethod(Description = "Returns ObjectOwners", EnableSession = false)]

        public List<ObjectOwner> GetObjectOwner()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select ownerSsnr, name, phoneNr, email from ObjectOwner", connectionString);
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
                oo.City = dataRow["brokerAddress"].ToString();
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
    }
}

