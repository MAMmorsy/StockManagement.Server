using StockManagement.Server.CORE.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Exceptions
{
    public class BaseException : Exception
    {
        public List<Error>? Errors { get; set; }
        public string? MoreDetails { get; set; }
    }
}
