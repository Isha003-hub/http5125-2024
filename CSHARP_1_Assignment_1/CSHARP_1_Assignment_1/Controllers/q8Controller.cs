using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.Encodings.Web;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {

        ///<summary>
        ///Receive an HTTP POST request to calculate the total quantity of SquashFellows plushies (small and large), compute the total of all SquashFellows, apply tax, and output the final total with each value prefixed by CAD($).  
        ///</summary>
        ///<return>
        ///The total quantity of small and large SquashFellows plushies, the combined total of all SquashFellows, and the final total after tax, with each value prefixed by CAD($).
        ///</return>
        ///<example>
        ///GET: api/q8/squashfellows
        ///POSThttp://localhost/api/q8/squashfellows
        ///Content-Type:application/x-www-form-urlencodedREQUEST BODY: Small=1&Large=1
        ///GET: api/q8/squashfellows
        ///POSThttp://localhost/api/q8/squashfellowsContent-Type:application/x-www-form-urlencodedREQUEST BODY: Small=2&Large=1
        ///GET: api/q8/squashfellows
        ///POSThttp://localhost/api/q8/squashfellowsContent-Type:application/x-www-form-urlencodedREQUEST BODY: Small=100&Large=100
        ///</example>

        [HttpPost(template: "SquashFellows")]
        public string SquashFellows([FromForm] int small, [FromForm] int large)
        {
            double s_total = small * 25.50;
            double l_total = large * 40.50;
            double sub_total = s_total + l_total;
            double tax = Math.Round(sub_total * 0.13,2);
            double tax_total = sub_total + tax;

            var cultureinfo = new CultureInfo("en-CA");

            string s_total_format = s_total.ToString("C2", cultureinfo);
            string l_total_format = l_total.ToString("C2", cultureinfo);
            string sub_total_format = sub_total.ToString("C2", cultureinfo);
            string tax_format = tax.ToString("C2", cultureinfo);
            string tax_total_format = tax_total.ToString("C2", cultureinfo);

            return $" {small} Small @ $25.50 = {s_total_format}; {large} Large @ $40.50 = {l_total_format}; Subtotal = {sub_total_format}; Tax= {tax_format} HST; Total = {tax_total_format}";
        }
    }
}
