using Microsoft.AspNetCore.Mvc;

namespace Echo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet(Name = "ping")]
        public async Task<EchoResponse> Get([FromQuery] string url)
        {
            var response = new EchoResponse();
            response.callerIp = HttpContext.Connection.RemoteIpAddress?.ToString();
            using var client = new HttpClient();
            response.message = await client.GetStringAsync(url);
            return response;
        }
    }
}