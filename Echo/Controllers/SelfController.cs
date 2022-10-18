using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Echo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SelfController : ControllerBase
    {

        [HttpGet(Name = "self")]
        public string Get()
        {
            try
            {
                return Dns.GetHostName();
            }
            catch
            {
                return HttpContext.Request.Host.Value;
            }
        }
    }
}