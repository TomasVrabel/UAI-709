using Microsoft.AspNetCore.Mvc;

namespace RestApi.Server.Controllers
{
    public class PingRequest
    {
        public string Name { get; set; }

    }

    public class PingResponse
    {
        public string Message { get; set; }
    }

    [ApiController]
    [Route("api/hello")]
    public class HelloController
    {
        [HttpGet("{name}")]
        public string Greet(string name)
        {
            return "Hello, " + name;
        }

        [HttpPost("ping")]
        public PingResponse Ping([FromBody] PingRequest request)
        {
            return new PingResponse() {
                Message = "Hello, " + request.Name,
            };
        }
    }
}
