using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class BasketballStatsTests
    {
        [TestMethod]
        public void BasketballStats_CalculateShootingPercentage()
        {
            // Arrange
            BasketballStats stats = new BasketballStats();

            decimal avg = stats.CalculateShootingPercentage(5, 20);

            Assert.AreEqual(.250m, avg);
        }

        [TestMethod]
        public void BasketballStats_Calculate3Point()
        {
            // Arrange
            BasketballStats stats = new BasketballStats();

            decimal avg = stats.Calculate3Point(5, 20);

            Assert.AreEqual(.250m, avg);
        }

        [TestMethod]
        public void BasketballStats_CalculateEFG()
        {
            // Arrange
            BasketballStats stats = new BasketballStats();

            decimal avg = stats.CalculateEFG(5, 5, 20);

            Assert.AreEqual(.375m, avg);
        }
    }
}
