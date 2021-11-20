using FrontShop;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TacoShop.Test.Unit.Controllers
{
    [Collection("Fixture collection")]
    public class TacoShopController
    {
        private readonly TestStartup<Startup> _fixture;
        private readonly HttpClient _client;

        public TacoShopController(TestStartup<Startup> fixture)
        {
            _fixture = fixture;
            _client = _fixture.Client;
        }
        [Fact]
        public async Task GetListOfTacoStores()
        {
            var response = await _client.GetAsync($"/TacoShop/SearchForMenu");
            var actualResponse = await response.Content.ReadAsStringAsync();

          
        }

    }
}
