using StockManagement.Server.EF.Repositories.Shared;
using StockManagement.Server.EF.Context;

namespace StockManagement.Server.EF.Repositories.Stocks
{
    public class StocksUnitOfWork : UnitOfWork
    {
        private readonly StocksDbContext _context;
        public StocksUnitOfWork(StocksDbContext context) : base(context)
        {
            _context = context;
        }
    }
}