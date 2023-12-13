using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StockManagement.Server.API.HubConfig;
using StockManagement.Server.CORE.Interfaces.Services;
using StockManagement.Server.SERVICES.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Helpers
{
    class StockHostedService : BackgroundService
    {
        private readonly TimeSpan _period = TimeSpan.FromSeconds(10);
        private readonly ILogger<StockHostedService> _logger;
        private readonly IServiceScopeFactory _factory;
        private readonly IHubContext<StocksHub> _hub;
        private int _executionCount = 0;
        public bool IsEnabled { get; set; }=true;

        public StockHostedService(
            ILogger<StockHostedService> logger,
            IServiceScopeFactory factory, IHubContext<StocksHub> hub)
        {
            _logger = logger;
            _factory = factory;
            _hub = hub;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using PeriodicTimer timer = new PeriodicTimer(_period);
            while (
                !stoppingToken.IsCancellationRequested &&
                await timer.WaitForNextTickAsync(stoppingToken))
            {
                try
                {
                    await using AsyncServiceScope asyncScope = _factory.CreateAsyncScope();
                    IStocksService stocksService = asyncScope.ServiceProvider.GetRequiredService<IStocksService>();
                    await stocksService.UpdateAllStocks();
                    var result = await stocksService.GetAllStocks();
                    _ = _hub.Clients.All.SendAsync("TransferStockData", result.Data, cancellationToken: stoppingToken);
                    _executionCount++;
                    _logger.LogInformation(
                        $"Stock HostedService executed: {_executionCount} Times");
                }
                catch (Exception ex)
                {
                    _logger.LogInformation(
                        $"Failed to execute Stock HostedService with exception message {ex.Message}.");
                }
            }
        }
    }
}
