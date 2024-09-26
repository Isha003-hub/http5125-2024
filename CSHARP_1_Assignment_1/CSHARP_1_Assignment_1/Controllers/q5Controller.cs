using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        ///<summary>
        ///Receives HTTP POST request and provides response message.
        ///</summary>
        ///<return>
        ///An HTTP response with a body echoing the request body.
        ///</return>
        ///<example>
        ///POST http://localhost:xx/api/q5/secret
        ///HEADER: Content-Type: application/json
        ///REQUEST BODY: 5
        ///POST http://localhost:xx/api/q5/secret
        ///HEADER: Content-Type: application/json
        ///REQUEST BODY: 5
        ///</example>
        [HttpPost(template:"secret")]
        public string secret([FromBody] int number)
        {
            return $"shh...the secret is {number}";
            
        }
    }
}


