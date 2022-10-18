using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Echo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SelfController : ControllerBase
    {

        [HttpGet(Name = "self")]
        public EchoResponse Get()
        {
            var response = new EchoResponse();
            response.callerIp = HttpContext.Connection.RemoteIpAddress?.ToString();

            try
            {
                response.message = Dns.GetHostName();
            }
            catch
            {
                response.message = HttpContext.Request.Host.Value;
            }

            return response;
        }
    }
}