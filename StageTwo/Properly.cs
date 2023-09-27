/*მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან. დაწერეთ
ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად
სწორად დასმული.*/

namespace StageTwo
{
    public static class Properly
    {
        public static bool IsProperly(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char symbol in sequence)
            {
                if (symbol == '(')
                {
                    stack.Push(symbol);
                }
                else if (symbol == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
