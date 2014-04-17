using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WebService
{
    /// <summary>
    /// Summary description for WebServiceUpg1
    /// </summary>
    [WebService(Namespace = "http://brokerapplication.org/", Description = "<b> Hämta en fils innehåll </b>")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUpg1 : System.Web.Services.WebService
    {
        public WebServiceUpg1() { }

        [WebMethod]
        public string GetFileContent(string filepath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (OutOfMemoryException e)
            {
                return "Error: Out of memory exception.";
            }
            catch (ArgumentException e)
            {
                return "Error: Ogiltlig sökväg.";
            }
            catch (FileNotFoundException e)
            {
                return "Error: Filen kunde inte hittas.";
            }
            catch (DirectoryNotFoundException e)
            {
                return "Error: Sökvägen kunde inte hittas";
            }
            catch (IOException e)
            {
                return "Error: I/O Exception.";
            }
            catch (Exception e)
            {
                return "Error: General exception";
            }                    
            
        }

    }
}
