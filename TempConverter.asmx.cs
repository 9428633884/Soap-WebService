using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Soap_WebService
{
    /// <summary>
    /// Summary description for TempConverter
    /// </summary>
    [WebService(Namespace = "http://Viralshah.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TempConverter : System.Web.Services.WebService
    {

        [WebMethod]
        public double ConvertFtoC( double far )
        {
            double cel = (((far-32) * 5 ) / 9 ) ;
            return cel;
        }
    }
}
