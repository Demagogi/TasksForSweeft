using StageTwo;

namespace Tests.StageTwoTests
{
    [TestFixture]
    public class NotContainsTests
    {
        [Test]
        public void TestNotContainWithEmptyArray()
        {
            // Arrange
            int[] arr = new int[] { };
            int expectedMissingElement = 1;

            // Act
            int actualMissingElement = NotContains.NotContain(arr);

            // Assert
            Assert.AreEqual(expectedMissingElement, actualMissingElement);
        }

        [Test]
        public void TestNotContainWithArrayWithMissingElement()
        {
            // Arrange
            int[] arr = new int[] { 1, 2, 3, 5 };
            int expectedMissingElement = 4;

            // Act
            int actualMissingElement = NotContains.NotContain(arr);

            // Assert
            Assert.AreEqual(expectedMissingElement, actualMissingElement);
        }

        [Test]
        public void TestNotContainWithArrayWithNoMissingElement()
        {
            // Arrange
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int expectedMissingElement = 6;

            // Act
            int actualMissingElement = NotContains.NotContain(arr);

            // Assert
            Assert.AreEqual(expectedMissingElement, actualMissingElement);
        }

        [Test]
        public void TestNotContainWithArrayWithNegativeElements()
        {
            // Arrange
            int[] arr = new int[] { -1, -2, -3, -5 };
            int expectedMissingElement = 1;

            // Act
            int actualMissingElement = NotContains.NotContain(arr);

            // Assert
            Assert.AreEqual(expectedMissingElement, actualMissingElement);
        }

        [Test]
        public void TestNotContainWithArrayWithDuplicateElements()
        {
            // Arrange
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5 };
            int expectedMissingElement = 6;

            // Act
            int actualMissingElement = NotContains.NotContain(arr);

            // Assert
            Assert.AreEqual(expectedMissingElement, actualMissingElement);
        }
    }
}
