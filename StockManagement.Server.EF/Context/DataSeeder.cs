using Microsoft.EntityFrameworkCore;
using StockManagement.Server.CORE.Helpers;
using StockManagement.Server.CORE.Interfaces.Repositories.Shared;
using StockManagement.Server.CORE.Interfaces.Repositories.Stocks;
using StockManagement.Server.CORE.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.EF.Context
{
    public static class DataSeeder
    {
        //private readonly IContextStocksRepository<Stock> _stockDbRepository;
        //private readonly IStocksUnitOfWork _unitOfWork;
        //public static DataSeeder(IContextStocksRepository<Stock> stockDbRepository, IStocksUnitOfWork unitOfWork)
        //{
        //    _stockDbRepository = stockDbRepository;
        //    _unitOfWork = unitOfWork;
        //}

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().HasData(
                        new Stock()
                        {
                            StockId = 1,
                            Name = "Vianet",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {
                            StockId = 2,
                            Name = "Agritek",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {
                            StockId = 3,
                            Name = "Akamai",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 4,
                            Name = "Baidu",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 5,
                            Name = "Blinkx",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 6,
                            Name = "Blucora",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 7,
                            Name = "Boingo",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 8,
                            Name = "Brainybrawn",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 9,
                            Name = "Carbonite",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 10,
                            Name = "China Finance",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 11,
                            Name = "ChinaCache",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 12,
                            Name = "ADR",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 13,
                            Name = "ChitrChatr",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 14,
                            Name = "Cnova",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 15,
                            Name = "Cogent",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 16,
                            Name = "Crexendo",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 17,
                            Name = "CrowdGather",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 18,
                            Name = "EarthLink",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 19,
                            Name = "Eastern",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 20,
                            Name = "ENDEXX",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 21,
                            Name = "Envestnet",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 22,
                            Name = "Epazz",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 23,
                            Name = "FlashZero",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 24,
                            Name = "Genesis",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 25,
                            Name = "InterNAP",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 26,
                            Name = "MeetMe",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 27,
                            Name = "Netease",
                            Price = Helper.RandomDecimal(),
                        },
                        new Stock()
                        {StockId = 28,   
                            Name = "Qihoo",
                            Price = Helper.RandomDecimal(),
                        }
                        );
                //};

                //_stockDbRepository.AddRange(stocks);
                //_unitOfWork.SaveChanges();
        }
    }
}
