
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int Add(int a, int b)
        { return a + b; }

        [WebMethod]
        public double FtoC(double a)
        { return (a - 32) * 5 / 9; }

        [WebMethod]
        public double CtoF(double a)
        { return (a*(9/5))+32; }

        [WebMethod]
        public string dt()
        { return DateTime.Now.ToString(); }



        [WebMethod]
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            // Add some items to the list
            names.Add("John");
            names.Add("Mary");
            names.Add("Tom");
            names.Add("Anca");
            names.Add("Andra");
            return names;
        }

        [WebMethod]

        public double LtoE(double a)

        { return a * 5; }

        [WebMethod]

        public double EtoL(double a)

        { return a / 5; }

    }
}
