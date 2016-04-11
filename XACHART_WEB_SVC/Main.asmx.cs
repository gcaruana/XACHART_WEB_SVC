using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Data.SqlClient;

namespace XACHART_WEB_SVC
{
    /// <summary>
    /// Summary description for Main
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Main : System.Web.Services.WebService
    {

        [WebMethod]
        public UTILITY[] GetEmployessXML()
        {
            UTILITY[] emps = new UTILITY[] {
            new UTILITY()
            {
                Id=101,
                Name="Nitin",
                Salary=10000
            },
            new UTILITY()
            {
                Id=102,
                Name="Dinesh",
                Salary=100000
            }
        };
            return emps;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetEmployessJSON()
        {
            UTILITY[] emps = new UTILITY[] {
            new UTILITY()
            {
                Id=101,
                Name="Nitin",
                Salary=10000
            },
            new UTILITY()
            {
                Id=102,
                Name="Dinesh",
                Salary=100000
            }
        };
            return new JavaScriptSerializer().Serialize(emps);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetPatientListJSONBYSURNAME()
        {
            PatientList[] PatLst = new PatientList[]{

            new PatientList[]

        }
    }
            
}
