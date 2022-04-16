using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.WebServices.Services
{
    public  interface IRestClient
    {
        TResponse Post<TRequest, TResponse>(TRequest request, string domain, string endpoint, IDictionary<string, string> headers = null);
        TResponse Get<TResponse>(IDictionary<string, string> parameters, string domain, string endpoint, IDictionary<string, string> headers = null);
        TResponse Put<TRequest, TResponse>(TRequest request, string domain, string endpoint, IDictionary<string, string> headers = null);
    }
}
