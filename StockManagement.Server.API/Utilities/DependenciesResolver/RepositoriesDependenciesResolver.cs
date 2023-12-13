using StockManagement.Server.CORE.Interfaces.Repositories.Stocks;
using StockManagement.Server.EF.Repositories.Stocks;

namespace GeneralAPI.API.Utilities.DependenciesResolver
{
    public class RepositoriesDependenciesResolver
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IStocksUnitOfWork, StocksUnitOfWork>();
            services.AddScoped(typeof(IContextStocksRepository<>), typeof(ContextStocksRepository<>));
        }
    }
}