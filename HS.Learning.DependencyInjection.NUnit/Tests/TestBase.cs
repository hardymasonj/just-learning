using HS.Learning.DependencyInjection.NUnit.RestClients;
using HS.Learning.WebServices.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.DependencyInjection.NUnit.Tests
{
    public class TestBase
    {
        private readonly IHost _host;
        protected IHost Host => _host;
        public TestBase()
        {
            var builder = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder();

            builder.ConfigureServices(services => 
                services.AddScoped<IRestClient, RestSharpWrapper>()
                .AddScoped<HS.Learning.WebServices.Endpoints.Weather.Status.Endpoint>()
            );
            
            _host = builder.Build();
        }
    }
}
