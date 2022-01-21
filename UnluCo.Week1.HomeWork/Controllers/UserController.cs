using Microsoft.AspNetCore.Mvc;
using UnluCo.Week1.HomeWork.Attribute;

namespace UnluCo.Week1.HomeWork.Controllers
{
    [Route("IsValidAdmin/[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
 
        [User] //Kontrol Attribute eklendi
        [HttpPost]
        public IActionResult Valid([FromForm] User valUser)
        {
            return Ok("Hoşgeldin Admin");


        }

    }
}
