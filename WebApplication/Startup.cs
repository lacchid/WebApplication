using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using SoapCore;
using WebApplication.Contract.NeutralVersion;
using WebApplication.NeutralVersion;
using WebApplication.Service;

namespace WebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<IWebServiceContract, WebService>();
            services.AddServices();
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddSoapCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSoapEndpoint<IWebServiceContract>("/Service.svc", new BasicHttpBinding(), SoapSerializer.DataContractSerializer);
            app.UseSoapEndpoint<IWebServiceContract>("/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

            app.UseMvc();
        }
    }
}
