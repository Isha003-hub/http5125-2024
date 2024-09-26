using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        ///<summary>
        ///Receives HTTP GET request and returns the area of a regular hexagon with side length using the formula.
        ///</summary>
        ///<returns>
        ///An HTTP response , which is area of regular hexagon in deciamal.
        ///</returns>
        ///<example>
        ///Get : api/q6/hexagone?side=1 -> 2.598076211353316
        ///Get : api/q6/hexagone?side=1.5 ->5.845671475544961
        ///Get : api/q6/hexagone?side=20 ->1039.2304845413264
        ///</example>
    [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            return (double)((double)(3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2));
        }
    }
}

