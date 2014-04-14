using CATest.localhost;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace CATest
{
    class Program
    {
        string connectionString = "server=localhost; Trusted_Connection=yes; database=PK Praktikfallet;";

        public DataSet GetObjectOwner()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select ownerSsnr, name, phoneNr, email from ObjectOwner", connectionString);
            DataSet objectOwnerDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(objectOwnerDS, "ObjectOwner");

            return objectOwnerDS;
        }
        public  List<ObjectOwner> GetObjectOwnerList()
        {
            DataSet objectOwner = GetObjectOwner();
            List<ObjectOwner> objectOwnerList = new List<ObjectOwner>();

            foreach (DataRow dataRow in objectOwner.Tables["ObjectOwner"].Rows)
            {
              
                ObjectOwner o = new ObjectOwner(dataRow["ownerSsnr"].ToString(), dataRow["name"].ToString(), dataRow["phoneNr"].ToString(), dataRow["email"].ToString());
                objectOwnerList.Add(o);
            }
            return objectOwnerList;

        }
        static void Main(string[] args)
        {
            //localhost.WebServiceUpg2 service = new localhost.WebServiceUpg2();

            Console.WriteLine(" Calling Web Methods");
            Console.WriteLine("---------------------");
            Console.WriteLine("\n Calling show Method");

            List<ObjectOwner> list = new Program().GetObjectOwnerList();

             foreach (ObjectOwner o in list)
             {
                 Console.WriteLine(o.Name);
             }

            Console.ReadLine();
        }
    }
}
