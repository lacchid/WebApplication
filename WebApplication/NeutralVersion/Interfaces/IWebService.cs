namespace WebApplication.NeutralVersion.Interfaces
{
    public interface IWebService
    {
        string XmlToJson(string xml);
        decimal Fibonacci(int n);
    }
}