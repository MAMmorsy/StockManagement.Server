using Microsoft.EntityFrameworkCore;
using StockManagement.Server.CORE.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.EF.Context
{
    public class StocksDbContext : DbContext
    {
        public StocksDbContext(DbContextOptions<StocksDbContext> options) : base(options) {
        }
        DbSet<Stock> Stocks { get; set; }
        DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }

        //private void SeedStocks(ModelBuilder builder)
        //{
        //    List<Stock> stocks = new List<Stock>()
        //    {
        //        new Stock{Name="Vianet",Price=}
        //    };

        //    builder.Entity<Stock>().HasData(stocks);
        //}


    }
}
