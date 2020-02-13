using NUnit.Framework;
using WebApplication.Service;
using WebApplication.Service.Interfaces;

namespace WebApplication.Tests
{
    [TestFixture]
    public class ConvertServiceTests
    {
        private readonly IConvertService _convertService;
        public ConvertServiceTests()
        {
            _convertService = new ConvertService();
        }

        [Test]
        public void XmlToJson_Test()
        {
            var r = _convertService.XmlToJson(string.Empty);
            Assert.AreEqual(string.Empty, r);

            r = _convertService.XmlToJson("<foo>hello</bar>");
            var containsError = r.Contains("Bad Xml format");
            Assert.IsTrue(containsError);

            r = _convertService.XmlToJson("<TRANS><HPAY><ID idType=\"externalId\">103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>");
            Assert.AreEqual("{\r\n  \"TRANS\": {\r\n    \"HPAY\": {\r\n      \"ID\": \"103\",\r\n      \"STATUS\": \"3\",\r\n      \"EXTRA\": {\r\n        \"IS3DS\": \"0\",\r\n        \"AUTH\": \"031183\"\r\n      },\r\n      \"INT_MSG\": null,\r\n      \"MLABEL\": \"501767XXXXXX6700\",\r\n      \"MTOKEN\": \"project01\"\r\n    }\r\n  }\r\n}", r);

            
        }
    }
}