﻿using System;
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
    [WebService(Namespace = "http://brokerapplication.org/", Description = "<b> Hämta databasens innehåll </b>")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]


        public class WebServiceUpg2 : System.Web.Services.WebService {
        DataAccessLayerWebService dal;

        public WebServiceUpg2()
        {
            this.dal = new DataAccessLayerWebService();
        }
        

        [WebMethod(Description = "Returns ObjectOwners", EnableSession = false)]
        public List<ObjectOwner> GetObjectOwner(ref string errorMessage)
        {
                return dal.GetObjectOwner(ref errorMessage); 
          
        }

        [WebMethod(Description = "Returns RealEstateBroker", EnableSession = false)]
        public List<RealEstateBroker> GetRealEstateBroker(ref string errorMessage)
        {
            return dal.GetRealEstateBroker(ref errorMessage);
        }

        [WebMethod(Description = "Returns Showings", EnableSession = false)]
        public List<Showing> GetShowing(ref string errorMessage)
        {
            return dal.GetShowing(ref errorMessage);
        }

        [WebMethod(Description = "Returns ProspectiveBuyers", EnableSession = false)]
        public List<ProspectiveBuyer> GetProspectiveBuyers(ref string errorMessage)
        {
            return dal.GetProspectiveBuyers(ref errorMessage);
        }

        [WebMethod(Description = "Returns RealEstateObjects", EnableSession = false)]
        public List<RealEstateObject> GetRealEstateObjects(ref string errorMessage)
        {
            return dal.GetRealEstateObjects(ref errorMessage);
        }
    }
}

