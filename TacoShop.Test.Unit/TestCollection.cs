
using WebApplication1;
using Xunit;

namespace TacoShop.Test.Unit
{

    [CollectionDefinition("Fixture collection")]
    public class TestCollection : ICollectionFixture<TestStartup<Startup>>
    {
    }
    
}
