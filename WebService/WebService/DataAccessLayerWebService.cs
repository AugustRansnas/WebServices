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

        public List<ObjectOwner> GetObjectOwner()
        {
            try
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

            catch (SqlException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (SystemException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            
        }



        public List<RealEstateBroker> GetRealEstateBroker()
        {
            try
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
            catch (SqlException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (SystemException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public List<Showing> GetShowing()
        {
            try
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
            catch (SqlException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (SystemException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<ProspectiveBuyer> GetProspectiveBuyers()
        {
            try
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
            catch (SqlException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (SystemException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<RealEstateObject> GetRealEstateObjects()
        {
            try
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
            catch (SqlException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (SystemException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}