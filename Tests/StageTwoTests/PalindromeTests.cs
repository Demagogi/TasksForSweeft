using StageTwo;

namespace Tests.StageTwoTests
{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void TestIsPalindromeWithEmptyString()
        {
            // Arrange
            string text = "";
            bool expectedIsPalindrome = true;

            // Act
            bool actualIsPalindrome = Palindrome.IsPalindrome(text);

            // Assert
            Assert.AreEqual(expectedIsPalindrome, actualIsPalindrome);
        }

        [Test]
        public void TestIsPalindromeWithSingleCharacter()
        {
            // Arrange
            string text = "a";
            bool expectedIsPalindrome = true;

            // Act
            bool actualIsPalindrome = Palindrome.IsPalindrome(text);

            // Assert
            Assert.AreEqual(expectedIsPalindrome, actualIsPalindrome);
        }

        [Test]
        public void TestIsPalindromeWithPalindrome()
        {
            // Arrange
            string text = "racecar";
            bool expectedIsPalindrome = true;

            // Act
            bool actualIsPalindrome = Palindrome.IsPalindrome(text);

            // Assert
            Assert.AreEqual(expectedIsPalindrome, actualIsPalindrome);
        }

        [Test]
        public void TestIsPalindromeWithNonPalindrome()
        {
            // Arrange
            string text = "hello";
            bool expectedIsPalindrome = false;

            // Act
            bool actualIsPalindrome = Palindrome.IsPalindrome(text);

            // Assert
            Assert.AreEqual(expectedIsPalindrome, actualIsPalindrome);
        }

        [Test]
        public void TestIsPalindromeWithSpaces()
        {
            // Arrange
            string text = " madam ";
            bool expectedIsPalindrome = true;

            // Act
            bool actualIsPalindrome = Palindrome.IsPalindrome(text);

            // Assert
            Assert.AreEqual(expectedIsPalindrome, actualIsPalindrome);
        }
    }
}
