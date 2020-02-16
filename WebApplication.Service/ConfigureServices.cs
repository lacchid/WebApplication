using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using WebApplication.Service.Interfaces;

namespace WebApplication.Service
{
    public static class ConfigureServices
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.TryAddSingleton<ISequencesService, SequencesService>();
            services.TryAddSingleton<IConvertService, ConvertService>();
        }
    }
}