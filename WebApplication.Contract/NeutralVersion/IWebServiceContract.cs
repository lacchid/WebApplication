using System.ServiceModel;

namespace WebApplication.Contract.NeutralVersion
{
    [ServiceContract]
    public interface IWebServiceContract
    {
        [OperationContract]
        string XmlToJson(string xml);
        [OperationContract]
        decimal Fibonacci(int n);
    }
}