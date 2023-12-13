﻿using AutoMapper;
using StockManagement.Server.CORE.Models.DTOs;
using StockManagement.Server.CORE.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.SERVICES.Mapper
{
    public class StockMapper
    {
        public static void ConfigureMapping(IMapperConfigurationExpression mapperConfigs)
        {
            mapperConfigs.CreateMap<Stock, StockDto>().ReverseMap();
        }
    }
}
