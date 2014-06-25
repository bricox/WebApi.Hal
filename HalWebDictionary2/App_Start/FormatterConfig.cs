using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using WebApi.Hal;

namespace HalWebDictionary2.App_Start
{
    public class FormatterConfig
    {
        public static void RegisterFormatters(HttpConfiguration configuration)
        {
            configuration.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                    new CamelCasePropertyNamesContractResolver();
            var xmlHalMediaTypeFormatter = new XmlHalMediaTypeFormatter();
            var jsonHalMediaTypeFormatter = new JsonHalMediaTypeFormatter
            {
                SerializerSettings = { ContractResolver = new CamelCasePropertyNamesContractResolver() }
            };

            jsonHalMediaTypeFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/hal+json"));
            xmlHalMediaTypeFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/hal+xml"));

            configuration.Formatters.Insert(0, xmlHalMediaTypeFormatter);
            configuration.Formatters.Insert(0, jsonHalMediaTypeFormatter);
        }
    }
}