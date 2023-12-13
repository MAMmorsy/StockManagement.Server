using StockManagement.Server.EF.Context;
using StockManagement.Server.EF.Repositories.Shared;

namespace StockManagement.Server.EF.Repositories.Stocks
{
    public class ContextStocksRepository<T> : BaseRepository<T> where T : class
    {
        protected StocksDbContext _context;
        public ContextStocksRepository(StocksDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
