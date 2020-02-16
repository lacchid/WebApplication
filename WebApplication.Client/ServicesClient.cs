using System;
using System.ServiceModel;
using System.Threading;
using WebApplication.Contract.NeutralVersion;

namespace WebApplication.Client
{
    public class ServicesClient : IWebServiceContract
    {
        private readonly IWebServiceContract _webService;

        public ServicesClient()
        {
            var basicHttpBinding = new BasicHttpBinding();
            var endpointAddress = new EndpointAddress(new Uri(string.Format("http://{0}:5050/Service.svc", Environment.MachineName)));
            var channelFactory = new ChannelFactory<IWebServiceContract>(basicHttpBinding, endpointAddress);
            _webService = channelFactory.CreateChannel();
        }

        public string XmlToJson(string xml)
        {
            return _webService.XmlToJson(xml);
        }

        public decimal Fibonacci(int n)
        {
            return _webService.Fibonacci(n);
        }
    }
}