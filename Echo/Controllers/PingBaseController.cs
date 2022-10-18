using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Echo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingBaseController : ControllerBase
    {
        [HttpGet(Name = "pingbase")]
        public async Task<string> Get([FromQuery] string url)
        {
            byte[] data = Convert.FromBase64String(url);
            string decodedString = Encoding.UTF8.GetString(data);
            using var client = new HttpClient();
            return await client.GetStringAsync(decodedString);
        }
    }
}