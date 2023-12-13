using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Models.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int StockId { get; set; }
        public Stock stock { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PersonName { get; set; }
    }
}
