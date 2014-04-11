using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebServiceUpg2
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUpg2 : System.Web.Services.WebService
    {
        string connectionString = "server=localhost; Trusted_Connection=yes; database=PK Praktikfallet;";

        [WebMethod(Description = "Returns ObjectOwners", EnableSession = false)]
        public DataSet GetObjectOwner()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select * from ObjectOwner", connectionString);
            DataSet objectOwnerDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(objectOwnerDS, "ObjectOwners");

            return objectOwnerDS;
        }

        [WebMethod]
        public List<ObjectOwner> GetObjectOwnerList()
        {
            DataSet objectOwnerDS = GetObjectOwner();
            List<ObjectOwner> objectOwnerList = new List<ObjectOwner>();

            foreach (DataRow dataRow in objectOwnerDS.Tables["ObjectOwner"].Rows)
            {
                objectOwnerList.Add(new ObjectOwner(dataRow["ownerSsnr"].ToString(), dataRow["name"].ToString(), dataRow["phoneNr"].ToString(), dataRow["email"].ToString()));
            }
            return objectOwnerList;
        }
    }
}

