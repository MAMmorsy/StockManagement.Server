using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Interfaces.Repositories.Shared
{
    public interface IUnitOfWork
    {
        IDatabaseTransaction BeginTransaction();
        int SaveChanges();
    }
}
