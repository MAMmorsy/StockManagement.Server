using Microsoft.Extensions.Hosting;
using StockManagement.Server.CORE.Helpers;
using StockManagement.Server.CORE.Interfaces.Services;
using StockManagement.Server.EF.Context;
using StockManagement.Server.SERVICES.Services;

namespace StockManagement.Server.API.Utilities.DependenciesResolver
{
    public class ServicesDependenciesResolver
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IStocksService, StocksService>();
            services.AddSingleton<TimerManager>();
        }
    }
}
