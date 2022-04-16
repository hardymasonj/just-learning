using HS.Learning.WebServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.WebServices.Endpoints
{
    public class EndpointBase
    {
        private readonly IRestClient _client;
        protected IRestClient Client => _client;
        public EndpointBase(IRestClient client)
        {
            this._client = client;
        }
    }
}
