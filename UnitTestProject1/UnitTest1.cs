using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LukeBrowne_S00187306;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestIncreasePriceMethod()
    {
      // arrange
      double increasedPrice;

      double priceToIncrease = 100;
      double percentageIncrease = 0.1;

      // act
      increasedPrice = Phone.IncreasePrice(percentageIncrease, priceToIncrease);

      // assert
      Assert.That.Equals(110);

    }
  }
}
