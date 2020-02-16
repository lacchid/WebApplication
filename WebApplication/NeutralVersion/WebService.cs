using WebApplication.Contract.NeutralVersion;
using WebApplication.Service.Interfaces;

namespace WebApplication.NeutralVersion
{
    public class WebService : IWebServiceContract
    {
        private readonly IConvertService _convertService;
        private readonly ISequencesService _sequencesService;
        public WebService(IConvertService convertService, ISequencesService sequencesService)
        {
            _convertService = convertService;
            _sequencesService = sequencesService;
        }
        public string XmlToJson(string xml)
        {
            return _convertService.XmlToJson(xml);
        }

        public decimal Fibonacci(int n)
        {
            return _sequencesService.Fibonacci(n);
        }
    }
}