using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ExcelWeb.SL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IExcelService, ExcelService>();

            return services;
        }
    }
}
