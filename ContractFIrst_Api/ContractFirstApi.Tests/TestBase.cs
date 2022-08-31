using Clients.v1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ContractFirstApi.Tests
{
    public abstract class TestBase
    {
        private IHost _testServer;
        protected ServiceProvider ServiceProvider { get; set; }

        public TestBase()
        {
            var builder = new HostBuilder()
         .ConfigureWebHost(webHost =>
         {
             webHost.UseEnvironment("Testing");
             webHost.UseTestServer().UseStartup<Startup>();
             ConfigureServicesForTest(webHost);
         });

            _testServer = builder.Start();
        }
        protected Client CreateClient()
        {
            var client = _testServer.GetTestClient();
            client.BaseAddress = new Uri(client.BaseAddress, "/v1/");

            return new Client(client);
        }

        private void ConfigureServicesForTest(IWebHostBuilder builder)
        {
            builder
                .ConfigureTestServices(services =>
                {
                    ServiceProvider = services.BuildServiceProvider();


                    services.AddMvcCore();

                    ServiceProvider = services.BuildServiceProvider();
                });
        }
    }
}
