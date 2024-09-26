using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        ///<summary>
        ///Receives HTTP GET request with string representation and outputs the current date(formatted yyyy-mm-dd)
        ///</summary>
        ///<returns>
        ///An HTTP response of the current date 
        ///</returns>
        ///<example>
        ///GET: api/q7/timemachine?days=1 -> 2000-01-02
        ///GET: api/q7/timemachine?days=-1 -> 1999-12-31
        ///</example>

        [HttpGet(template: "timemachine")]

        public string timemachine(double days)
        {
            //current date
            //.
            DateTime cdate = DateTime.Today;
            DateTime answer = cdate.AddDays(days);
            return answer.ToString("yyyy-MM-dd");
            
            
        }
    }
}
