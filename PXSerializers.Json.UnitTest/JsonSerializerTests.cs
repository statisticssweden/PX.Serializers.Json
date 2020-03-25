using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PXSerializers.Json.UnitTest
{
    [TestClass]
    public class JsonSerializerTests
    {
        [TestMethod]
        public void ShouldCreateNewJsonSerializer()
        {
            var serialize = new JsonSerializer();
            Assert.IsNotNull(serialize);
        }
    }
}
