using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Temperature
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
        public string FahrenheitToCelsius(int fahrenheit)
        {
            double celsius = ((fahrenheit - 32)/9)*5;
            return celsius.ToString();
        }

        [WebMethod]
        public string CelsiusToFahrenheit(int celsius)
        {
            double fahrenheit = (celsius*9)/ 5 + 32;
            return fahrenheit.ToString();
        }

    }
}
