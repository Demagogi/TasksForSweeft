using StageTwo;

namespace Tests.StageTwoTests
{
    [TestFixture]
    public class VariantsTests
    {
        [Test]
        public void TestCountVariantsWithZeroStairCount()
        {
            // Arrange
            int stairCount = 0;
            int expectedCountVariants = 1;

            // Act
            int actualCountVariants = Variants.CountVariants(stairCount);

            // Assert
            Assert.AreEqual(expectedCountVariants, actualCountVariants);
        }

    }
}
