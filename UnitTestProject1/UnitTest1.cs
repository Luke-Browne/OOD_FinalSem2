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
      decimal increasedPrice;

      decimal priceToIncrease = 100; // 100 x 10% = 110
      decimal percentageIncrease = 0.1M;

      // act
      increasedPrice = Phone.IncreasePrice(percentageIncrease, priceToIncrease);

      // assert
      Assert.That.Equals(110); // this is the 110

    }
  }
}
