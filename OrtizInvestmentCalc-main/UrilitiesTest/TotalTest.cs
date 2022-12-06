namespace UtilitiesTest
{
    using Utilities;

    [TestClass]
    public class TotalTest
    {
        [TestMethod]
        public void ShouldCalculateInvestmentTotal()
        {
            Total total = new Total();
            total.Compounds = 12;
            total.Interest = 5; 
            total.Principal = 10000;
            total.Years = 30;
            double actual = Math.Round(total.Full, 2);
            double expected = 44677.44;
            Assert.AreEqual(expected, actual);

        }
    }
}