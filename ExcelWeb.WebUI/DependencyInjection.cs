using AutoMapper;
using ExcelWeb.WebUI.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace ExcelWeb.WebUI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            mappingConfig.AssertConfigurationIsValid();

            services.AddSingleton(mappingConfig.CreateMapper());

            return services;
        }
    }
}
