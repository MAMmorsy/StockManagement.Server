using Microsoft.AspNetCore.SignalR;
using StockManagement.Server.CORE.Models.DTOs;

namespace StockManagement.Server.API.HubConfig
{
    public class StocksHub:Hub
    {
        public async Task BroadcastChartData(List<StockDto> data) =>
            await Clients.All.SendAsync("broadcastchartdata", data);
    }
}
