using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q.Reporsitory.Mapping;
using Q.Service.Service.Generic;
using Q.VM.ViewModels;
using Q.Service.Service.LookUps;
using Q.Reporsitory.Reporsitory.Generic;
using Q.Reporsitory.Reporsitory.LookUps;


namespace Q.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,IConfiguration configuration)
        {
            //////LookUps
            ///LkFormat
            services.AddScoped<IGenericRepo<LkFormatVM>, LkFormatRepo>();
            services.AddScoped<IGenericService<LkFormatVM>, LkFormatService>();
            /////
            //////LkPubilsher
            services.AddScoped<IGenericRepo<LkPubilsherVM>, LkPubilsherRepo>();
            services.AddScoped<IGenericService<LkPubilsherVM>, LkPubilsherService>();
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
