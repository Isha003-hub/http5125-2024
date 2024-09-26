using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    ///<summary>
    ///Recives an Http POST request with Empty Header and Empty Body and provides a response message.
    ///</summary>
    ///<returns>
    ///An HTTP response with Knock knock joke "Who's there?"
    ///<example>
    ///POST api/q4/knockkock
    ///HEADER:(None)
    ///BODY:(None)
    ///</example>
    ///</returns>
    public class q4Controller : ControllerBase
    {
        [HttpPost(template: "knockknock")]
        public string Knockknock()
        {
            return "Who's there?";
        }
    }
}
