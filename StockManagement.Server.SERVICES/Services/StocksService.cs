using AutoMapper;
using StockManagement.Server.CORE.Enums;
using StockManagement.Server.CORE.Helpers;
using StockManagement.Server.CORE.Interfaces.Repositories.Stocks;
using StockManagement.Server.CORE.Interfaces.Services;
using StockManagement.Server.CORE.Models.DTOs;
using StockManagement.Server.CORE.Models.Entities;
using StockManagement.Server.SERVICES.Validators;
using System.Linq.Expressions;

namespace StockManagement.Server.SERVICES.Services
{
    public class StocksService : IStocksService
    {
        private readonly IContextStocksRepository<Order> _orderRepository;
        private readonly IContextStocksRepository<Stock> _stockRepository;
        private readonly IStocksUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public StocksService(IStocksUnitOfWork unitOfWork, IMapper mapper,
            IContextStocksRepository<Stock> stockRepository,
            IContextStocksRepository<Order> orderRepository
            )
        {
            _orderRepository = orderRepository;
            _stockRepository = stockRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<bool>> AddNewOrder(OrderInsertDto order)
        {
            Response<bool> response = new Response<bool>();
            try
            {
                response.Errors = ValidatorHandler.Validate(order, (InsertOrderValidator)Activator.CreateInstance(typeof(InsertOrderValidator)));
                if (response.Errors.Any())
                {
                    response.IsSucceded = false;
                    response.ResponseCode = (int)ResponseCodesEnum.InvalidParameters;
                    return response;
                }
                var newOrder = _mapper.Map<Order>(order);
                await _orderRepository.AddAsync(newOrder);
                response.SuccessObjCount = _unitOfWork.SaveChanges();
                response.Data = response.SuccessObjCount >= 1;
                response.ResponseCode = (int)ResponseCodesEnum.SaveAllRecords;
                return response;
            }
            catch (Exception ex)
            {
                response.Errors?.Add(new Error() { ErrorMessage = ex.Message });
                response.IsSucceded = false;
                response.ResponseCode = (int)ResponseCodesEnum.DbException;
            }
            return response;
        }

        public async Task<Response<List<OrderDto>>> GetAllOrders()
        {
            Response<List<OrderDto>> response = new Response<List<OrderDto>>();
            try
            {
                var orders = _orderRepository.FindAll(e => true);
                var stock = _stockRepository.FindAll(e => true);
                var stockOrder= orders.Join(// outer sequence 
                      stock,  // inner sequence 
                      orders => orders.StockId,    // outerKeySelector
                      stock => stock.StockId,  // innerKeySelector
                      (orders, stock) => new OrderDto // result selector
                      {
                          OrderId = orders.OrderId,
                          Quantity = orders.Quantity,
                          PersonName=orders.PersonName,
                          StockId=stock.StockId,
                          Name=stock.Name,
                      }).ToList();
                
                response.Data = stockOrder;
            }
            catch (Exception ex)
            {
                response.Errors?.Add(new Error() { ErrorMessage = ex.Message });
            }
            return response;
        }

        public async Task<Response<List<StockDto>>> GetAllStocks()
        {
            Response<List<StockDto>> response = new Response<List<StockDto>>();
            try
            {
                var stocks = await _stockRepository.GetAllAsync();
                List<StockDto> allStocks = _mapper.Map<List<Stock>, List<StockDto>>(stocks.ToList());
                response.Data = allStocks;
            }
            catch (Exception ex)
            {
                response.Errors?.Add(new Error() { ErrorMessage = ex.Message });
            }
            return response;
        }
        
        public async Task UpdateAllStocks()
        {
            try
            {
                var stocks = await _stockRepository.GetAllAsync();

                stocks.ToList()
                      .ForEach(a => a.Price = Helper.RandomDecimal());

                _unitOfWork.SaveChanges();

            }
            catch (Exception ex)
            {
                
            }
            
        }

        public async Task<Response<StockDto>> GetStockById(StockSelectDto stockSelectDto)
        {
            Response<StockDto> response = new Response<StockDto>();
            try
            {
                response.Errors = ValidatorHandler.Validate(stockSelectDto, (SelectStockValidator)Activator.CreateInstance(typeof(SelectStockValidator)));;
                if (response.Errors.Any())
                {
                    response.IsSucceded = false;
                    response.ResponseCode = (int)ResponseCodesEnum.InvalidParameters;
                    return response;
                }
                var stock = await _stockRepository.FirstAsync(s => s.StockId == stockSelectDto.StockId);
                if (stock == null)
                {
                    response.ResponseCode = (int)ResponseCodesEnum.SuccessWithoutData;
                    response.Errors?.Add(new Error() { ErrorMessage = "No stocks found with this Id" });
                    response.IsSucceded = false;
                    return response;
                }
                response.SuccessObjCount = 1;
                response.IsSucceded = true;
                response.ResponseCode = (int)ResponseCodesEnum.SuccessWithData;
                var data = _mapper.Map<StockDto>(stock);
                response.Data = data;
            }
            catch (Exception ex)
            {
                response.Errors?.Add(new Error() { ErrorMessage = ex.Message });
            }
            return response;
        }

    }
}
