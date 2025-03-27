using LotteryService.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LotteryService.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class LotteryController : ControllerBase
    {
        private readonly ILotteryService _lotteryService;
        public LotteryController(ILotteryService lotteryService)
        {
            _lotteryService = lotteryService;
        }   

        [HttpGet]
        public async Task<ActionResult> ResultLottery()
        {
var res = await _lotteryService.GetResultLottery();
           if (res.Success)
           {
               return Ok(res);
           }
           else
           {
              return StatusCode(428, res); 
           }
        }
    }
}