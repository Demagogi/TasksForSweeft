using StageTwo;

namespace Tests.StageTwoTests
{
    [TestFixture]
    public class ProperlyTests
    {
        [Test]
        public void TestIsProperlyWithEmptyString()
        {
            // Arrange
            string sequence = "";
            bool expectedIsProperly = true;

            // Act
            bool actualIsProperly = Properly.IsProperly(sequence);

            // Assert
            Assert.AreEqual(expectedIsProperly, actualIsProperly);
        }

        [Test]
        public void TestIsProperlyWithBalancedSequence()
        {
            // Arrange
            string sequence = "()()";
            bool expectedIsProperly = true;

            // Act
            bool actualIsProperly = Properly.IsProperly(sequence);

            // Assert
            Assert.AreEqual(expectedIsProperly, actualIsProperly);
        }

        [Test]
        public void TestIsProperlyWithUnbalancedSequence()
        {
            // Arrange
            string sequence = "(()";
            bool expectedIsProperly = false;

            // Act
            bool actualIsProperly = Properly.IsProperly(sequence);

            // Assert
            Assert.AreEqual(expectedIsProperly, actualIsProperly);
        }
    }
}
