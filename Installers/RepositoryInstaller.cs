
using LotteryService.Services;
using LotteryService.Services.Interface;

namespace LotteryService.Installers
{
    public class RepositoryInstaller : IInstallers
    {
        public void InstallServices(IServiceCollection services)
        {
           //Services
           services.AddScoped<ILotteryService, LotteryServices>();
        }
    }
}