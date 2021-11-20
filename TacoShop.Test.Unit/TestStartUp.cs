using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Net.Http;
using TacoShop.Domain.Interfaces.Repository;
using TacoShop.Logic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using TacoShop.Domain.Interfaces.Service;
using TacoShop.Data.Repositories;

namespace TacoShop.Test.Unit
{
    public class TestStartup<TStartup> where TStartup : class
    {
        public MockRepository MockRepository { get; }
        private readonly TestServer _server;
        public HttpClient Client { get; }
        public IConfiguration Configuration { get; }
        public Mock<IBuyRepository> BuyRepository { get; set; }
        public TestStartup()
        {
            MockRepository = new MockRepository(MockBehavior.Default);
            BuyRepository = MockRepository.Create<IBuyRepository>();
            _server = new TestServer
               (
                   new WebHostBuilder()
                   .UseStartup<TStartup>()
                   .ConfigureAppConfiguration((context, config) =>
                   {
                       config
                       .AddJsonFile("appsettings.json").AddJsonFile("appsettings.Development.json")
                       .AddEnvironmentVariables();
                   })
                   .ConfigureTestServices(services =>
                   {
                       ConfigureServices(services);
                   })
               );
            Configuration = _server.Host.Services.GetService<IConfiguration>();
            Client = _server.CreateClient();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBuyService, BuyService>();
            services.AddScoped<IBuyRepository, BuyRepository>();
            services.AddTransient(serviceProvider => BuyRepository.Object);
            services.AddControllers();
            services.AddHttpClient();
        }  
    }
}
