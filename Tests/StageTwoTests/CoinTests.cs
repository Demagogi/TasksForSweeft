using StageTwo;

namespace Tests.StageTwoTests
{
    [TestFixture]
    public class CoinTests
    {
        [Test]
        public void TestMinSplitWithZeroAmount()
        {
            // Arrange
            int amount = 0;
            int expectedMinCoins = 0;

            // Act
            int actualMinCoins = Coins.MinSplit(amount);

            // Assert
            Assert.That(actualMinCoins, Is.EqualTo(expectedMinCoins));
        }

        [Test]
        public void TestMinSplitWithPositiveAmount()
        {
            // Arrange
            int amount = 100;
            int expectedMinCoins = 2;

            // Act
            int actualMinCoins = Coins.MinSplit(amount);

            // Assert
            Assert.That(actualMinCoins, Is.EqualTo(expectedMinCoins));
        }
    }
}
