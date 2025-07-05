using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Q.Reporsitory.Mapping;
using Q.Reporsitory.Reporsitory.Generic;
using Q.Reporsitory.Reporsitory.LookUps;
using Q.Service.Service.Generic;
using Q.Service.Service.LookUps;
using Q.VM.ViewModels;


namespace Q.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            //////LookUps
            ///LkFormat
            services.AddScoped<IGenericRepo<LkFormatVM>, LkFormatRepo>();
            services.AddScoped<IGenericService<LkFormatVM>, LkFormatService>();
            /////

            //Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
