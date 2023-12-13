using AutoMapper;
using StockManagement.Server.SERVICES.Mapper;

namespace StockManagement.Server.SERVICES.Mapper
{
    public class MapperConfigurator
    {
        public static MapperConfiguration ConfigureMappings()
        {
            var mapperConfiguration = new MapperConfiguration(mapperConfigs =>
            {

                OrderMapper.ConfigureMapping(mapperConfigs);
                StockMapper.ConfigureMapping(mapperConfigs);
            });

            return mapperConfiguration;
        }
    }
}
