using Microsoft.Extensions.DependencyInjection;
using WebApplication.Service.Interfaces;

namespace WebApplication.Service
{
    public static class ConfigureServices
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ISequencesService, SequencesService>();
            services.AddScoped<IConvertService, ConvertService>();
        }
    }
}