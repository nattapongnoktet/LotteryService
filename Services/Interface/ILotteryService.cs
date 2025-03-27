using LotteryService.Dto;

namespace LotteryService.Services.Interface;

public interface ILotteryService
{
    Task<mResult> GetResultLottery();
}
