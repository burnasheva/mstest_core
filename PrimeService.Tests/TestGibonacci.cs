using Hello;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.Tests
{
    [TestClass]
    public class TestGibonacci
    {
        [TestMethod]
        public void CheckGibonacci()
        {
            var generator = new FibonacciGenerator();

            Assert.IsNotNull(generator, "Generator is null");
        }
    }
}