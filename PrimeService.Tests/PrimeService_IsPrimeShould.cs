using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace PrimeService.Tests
{
	[TestClass]
	public class PrimeService_IsPrimeShould
	{
		private readonly Prime.Services.PrimeService _primeService;

		public PrimeService_IsPrimeShould()
		{
			_primeService = new Prime.Services.PrimeService();
		}

		[TestMethod]
		public void ReturnFalseGivenValueOf1()
		{
			var result = _primeService.IsPrime(1);

			Assert.IsFalse(result, $"1 should not be prime");
		}
	}
}
