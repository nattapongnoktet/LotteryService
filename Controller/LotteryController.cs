using Microsoft.AspNetCore.Mvc;

namespace LotteryService.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LotteryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from .NET 8 API!" });
        }
    }
}