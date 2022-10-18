using Microsoft.AspNetCore.Mvc;

namespace Echo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet(Name = "ping")]
        public async Task<string> Get([FromQuery] string url)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url);
        }
    }
}