using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    ///<summary>
    ///Receive a number as input from the user and output the cube of that number.
    ///</summary>
    ///<returns>
    ///cube of the number given by the user
    ///</returns>
    ///<parameter name="base">The number Entered by the user</parameter>
    ///Get : api/q3/cube/{base}
    ///Get : api/q3/cube/4 -> 64
    ///Get : api/q3/cube/-4 -> -64
    ///Get : api/q3/cube/10 -> 1000
    public class q3Controller : ControllerBase
    {
        [HttpGet(template: "cube/{Base}")]
        public int cube(int Base)
        {
            return (int)Math.Pow(Base, 3);
        }
    }
}
