using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.WebAPI
{
    class Request:RestRequest
    {
        public DateTimeOffset SentAt { get; set; }

        public Uri AbsoluteUrl { get; private set; }
        public string BaseUrl { get; private set; }
        public string ResourcePath { get; private set; }

        public Request(Uri absoluteUrl, string baseUrl, string resourcePath, Method method) : base(resourcePath, method)
		{

            //var url = GetUri();
            //var baseUrl = GetBaseUrl(url);
            //var resourcePath = GetResourcePath(url);

            //foreach (var header in Headers.Where(h => h.Name != Header.ContentType))
            //    request.AddHeader(header.Name, header.Value);

            //request.AddParameter(Headers.Single(h => h.Name == Header.ContentType).Value, Body, ParameterType.RequestBody);



            AbsoluteUrl = absoluteUrl;
            BaseUrl = baseUrl;
            ResourcePath = resourcePath;
        }
    }
}
