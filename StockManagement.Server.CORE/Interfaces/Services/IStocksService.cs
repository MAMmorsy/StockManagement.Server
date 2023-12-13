using StockManagement.Server.CORE.Models.DTOs;
//using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace StockManagement.Server.CORE.Interfaces.Services
{
    public interface IStocksService
    {
        Task<Response<StockDto>> GetStockById(StockSelectDto stockSelectDto);
        Task<Response<List<StockDto>>> GetAllStocks();
        Task UpdateAllStocks();
        Task<Response<List<OrderDto>>> GetAllOrders();
        Task<Response<bool>> AddNewOrder(OrderInsertDto order);
    }
}
