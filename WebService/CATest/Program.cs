using CATest.ourReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;




namespace CATest
{
class Program {

        static void Main(string[] args)
        {
           
            Console.WriteLine(" Calling Web Methods");
            Console.WriteLine("---------------------");
            Console.WriteLine("\n Calling show Method");

            WebServiceUpg2SoapClient client = new WebServiceUpg2SoapClient();

            List<ObjectOwner> list = client.GetObjectOwner();

             foreach (ObjectOwner o in list)
             {
                 Console.WriteLine(o.Name);
             }

             Console.WriteLine("\n Calling show Method");
            Console.ReadLine();
        }
    }
}
