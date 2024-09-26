using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Globalization;
using System.Security.Cryptography;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {

        ///<summary>
        ///
        ///</summary>

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
