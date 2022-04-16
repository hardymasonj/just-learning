using HS.Learning.WebServices.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.DependencyInjection.NUnit.RestClients
{
    public class RestSharpWrapper : IRestClient
    {
        public TResponse Get<TResponse>(IDictionary<string, string> parameters, string domain, string endpoint, IDictionary<string, string> headers = null)
        {
            var request = new RestSharp.RestRequest(new Uri(new Uri(domain), this.GetUrl(endpoint, parameters)));
            
            request.Method = RestSharp.Method.Get;
            var client = new RestSharp.RestClient();
            return client.GetAsync<TResponse>(request).GetAwaiter().GetResult(); //Sync it up
        }
        private string GetUrl(string endpoint, IDictionary<string, string> queryParameters)
        {
            if (queryParameters is null || !queryParameters.Any()) { return endpoint; }
            char paramSeparator = '?';
            foreach(var parameter in queryParameters)
            {
                endpoint = GetUrl(endpoint, parameter, ref paramSeparator);
            }
            return endpoint;
        }
        private string GetUrl(string endpoint, KeyValuePair<string, string> parameter, ref char separator)
        {
            if (!string.IsNullOrWhiteSpace(parameter.Key) && !string.IsNullOrWhiteSpace(parameter.Value))
            {
                return endpoint;
            }
            if (endpoint.Contains("{" + parameter.Key + "}")) return endpoint.Replace("{" + parameter.Key + "}", parameter.Value);
            
            //Default
            endpoint += separator + parameter.Key + "=" + parameter.Value;
            separator = '&';
            return endpoint;
        }

        public TResponse Post<TRequest, TResponse>(TRequest request, string domain, string endpoint, IDictionary<string, string> headers = null)
        {
            throw new NotImplementedException();
        }

        public TResponse Put<TRequest, TResponse>(TRequest request, string domain, string endpoint, IDictionary<string, string> headers = null)
        {
            throw new NotImplementedException();
        }
    }
}
