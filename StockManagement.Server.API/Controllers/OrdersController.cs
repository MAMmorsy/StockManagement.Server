using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Server.CORE.Interfaces.Services;
using StockManagement.Server.CORE.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace StockManagement.Server.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IStocksService _stocksService;
        public OrdersController(IStocksService stocksService)
        {
            _stocksService = stocksService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([Required] OrderInsertDto orderInsertDto)
        {
            try
            {
                var result = await _stocksService.AddNewOrder(orderInsertDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                var result = await _stocksService.GetAllOrders();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
