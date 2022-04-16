using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.DependencyInjection.NUnit.Tests
{
    public class WeatherStatusTest : TestBase
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void StatusTest()
        {
            var endpoint = this.Host.Services.GetService(typeof(WebServices.Endpoints.Weather.Status.Endpoint)) as WebServices.Endpoints.Weather.Status.Endpoint;
            Assert.IsNotNull(endpoint, "Endpoint is null");
            var status = endpoint.GetStatus();
            Assert.IsNotNull(status);
            Assert.AreEqual("OK", status.Status);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
