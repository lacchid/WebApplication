using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using WebApplication.Service.Interfaces;
using Formatting = Newtonsoft.Json.Formatting;

namespace WebApplication.Service
{
    public class ConvertService : IConvertService
    {
        public string XmlToJson(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml)) return string.Empty;
            try
            {
                var xmlDocument = new XmlDocument();
                using (var stringReader = new StringReader(xml))
                {
                    xmlDocument.Load(stringReader);
                    var nodes = xmlDocument.SelectNodes("//*");
                    if (nodes != null)
                    {
                        foreach (XmlNode node in nodes)
                        {
                            node.Attributes?.RemoveAll();
                        }
                    }
                    var json = JsonConvert.SerializeXmlNode(xmlDocument.DocumentElement, Formatting.Indented);
                    return json;
                }
            }
            catch (Exception e)
            {
                return $"Bad Xml format. Input:{xml}. ExcepionDetails: {JsonConvert.SerializeObject(e)}";
            }
            
        }
    }
}