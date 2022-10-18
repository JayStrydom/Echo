using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Echo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingBaseController : ControllerBase
    {
        [HttpGet(Name = "pingbase")]
        public async Task<EchoResponse> Get([FromQuery] string url)
        {
            var response = new EchoResponse();
            response.callerIp = HttpContext.Connection.RemoteIpAddress?.ToString();
            byte[] data = Convert.FromBase64String(url);
            string decodedString = Encoding.UTF8.GetString(data);
            using var client = new HttpClient();
            response.message = await client.GetStringAsync(decodedString);
            return response;
        }
    }
}