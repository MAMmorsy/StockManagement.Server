using StockManagement.Server.CORE.Interfaces.Repositories.Shared;
using StockManagement.Server.CORE.Interfaces.Repositories.Stocks;
using Microsoft.EntityFrameworkCore;

namespace StockManagement.Server.EF.Repositories.Shared
{
    public class UnitOfWork : IStocksUnitOfWork
    //public class UnitOfWork : ISTEMUnitOfWork, ITechUnitOfWork ,ISuperiorMSUnitOfWork, ISecControlUnitOfWork, ISuperiorsSeatingAnnouncementUnitOfWork, ISuperiorsNategaUnitOfWork, ISuperiorConfigurationUnitOfWork
    {
        private readonly DbContext _context;


        //private IBaseRepository<CdeYear> _CdeYears;

        //public IBaseRepository<CdeYear> CdeYears => _CdeYears;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IDatabaseTransaction BeginTransaction()
        {
            return new DatabaseTransaction(_context);
        }
    }
}
