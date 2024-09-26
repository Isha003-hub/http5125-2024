using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1_Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Recives a user input and outputs a greeting message that says 'hi' and includes the user's name, which they input.
        /// </summary>
        ///<returns>
        /// Returns a greeting message "Hi {name}"
        /// </returns>
        /// <param name="name">user's name , passed as a parameter 'name'</param>
        /// <example>
        /// GET api/q2/greeting?name={name} -> "Hi Isha"
        ///GET api/q2/greeting?name={name} -> "Hi Akshi"
        ///</example>
        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            return $"Hi {name}!";
        }
        
    }
}
