using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.CORE.Models.Entities
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public List<Order> Orders { get; set; }

    }
}
