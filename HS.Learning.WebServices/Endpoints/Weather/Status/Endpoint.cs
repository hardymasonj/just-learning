using HS.Learning.WebServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.WebServices.Endpoints.Weather.Status
{
    public class Endpoint : EndpointBase
    {
        public Endpoint(IRestClient client) : base(client)
        {

        }
        public Response GetStatus()
        {
            return this.Client.Get<Response>(null, "https://api.weather.gov", string.Empty, null);
        }
    }
}
