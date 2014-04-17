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
            catch (OutOfMemoryException)
            {
                return "Error: Out of memory exception. Det finns inte tillräckligt med minne tillgängligt för att fortsätta.";
            }
            catch (ArgumentException)
            {
                return "Error: ArgumentException. Ogiltlig sökväg.";
            }
            catch (FileNotFoundException)
            {
                return "Error: FileNotFoundException. Filen kunde inte hittas.";
            }
            catch (DirectoryNotFoundException)
            {
                return "Error: DirectoryNotFoundException. Sökvägen kunde inte hittas";
            }
            catch (IOException)
            {
                return "Error: I/O Exception. Något gick fel med filtypen.";
            }
            catch (Exception)
            {
                return "Error: General exception. Något gick fel med filtypen.";
            }                                
        }
    }
}
