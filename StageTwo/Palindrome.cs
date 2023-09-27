/* დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი და აბრუნებს
პალინდრომია თუ არა. (პალინდრომი არის ტექსტი რომელიც ერთნაირად
იკითხება ორივე მხრიდან).*/

namespace StageTwo
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string text)
        {
            string textLower = text.Replace(" ", "").ToLower();

            int firstIndex = 0;
            int lastIndex = textLower.Length - 1;

            while (firstIndex < lastIndex)
            {
                if (textLower[firstIndex] != textLower[lastIndex])
                {
                    return false;
                }

                firstIndex++;
                lastIndex--;
            }

            return true;
        }
    }
}
