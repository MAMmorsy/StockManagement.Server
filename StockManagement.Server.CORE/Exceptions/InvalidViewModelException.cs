using StockManagement.Server.CORE.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Exceptions
{
    public class InvalidViewModelException : BaseException
    {
        public InvalidViewModelException(List<Error> errors)
        {
            Errors = errors;
        }
    }
}
