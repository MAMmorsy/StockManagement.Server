using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using StockManagement.Server.API.HubConfig;
using StockManagement.Server.CORE.Helpers;
using StockManagement.Server.CORE.Interfaces.Services;
using StockManagement.Server.CORE.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace StockManagement.Server.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IHubContext<StocksHub> _hub;
        private readonly TimerManager _timer;
        private readonly IStocksService _stocksService;
        public StocksController(IStocksService stocksService, TimerManager timer, IHubContext<StocksHub> hub)
        {
            _stocksService = stocksService;
            _timer = timer;
            _hub = hub;
        }

        [HttpGet]
        [Route("GetStockById")]
        public async Task<IActionResult> GetStockById([FromQuery] StockSelectDto stockSelectDto)
        {
            try
            {
                var result = await _stocksService.GetStockById(stockSelectDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllStocks")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _stocksService.GetAllStocks();
                _timer.PrepareTimer(() => _hub.Clients.All.SendAsync("TransferStockData", result.Data));
                return Ok(new { Message = "Request Completed" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpGet]
        [Route("SelectAllStocks")]
        public async Task<IActionResult> SelectAllStocks()
        {
            try
            {

                var result = await _stocksService.GetAllStocks();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
