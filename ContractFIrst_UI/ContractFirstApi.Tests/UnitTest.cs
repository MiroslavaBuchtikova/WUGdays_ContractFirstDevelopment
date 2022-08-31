using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace ContractFirstApi.Tests
{
    [TestClass]
    public class UnitTest : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = CreateClient().PetsGetAsync("10").GetAwaiter().GetResult();
            //result.Name.ShouldBe("Dog");
        }
     
    }
}