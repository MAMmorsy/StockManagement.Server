using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Models.DTOs
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int StockId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PersonName { get; set; }
        public string Name { get; set; }

    }
}
