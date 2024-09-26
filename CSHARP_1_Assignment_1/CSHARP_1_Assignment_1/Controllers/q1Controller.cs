using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        ///<summary>
        ///HTTP Get Request to Returns a welcome message
        ///</summary>
        ///<returns>
        ///Returns "Welcome to 5125!"
        ///</returns>
        ///<example>
        ///GET api/q1/welcome -> "Welcome to 5125!"
        ///</example>
        [HttpGet(template: "welcome")]

        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }
}