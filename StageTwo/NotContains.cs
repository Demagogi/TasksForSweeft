/*მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. დაწერეთ
ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს მინიმალურ მთელ
რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.*/

namespace StageTwo
{
    public static class NotContains
    {
        public static int NotContain(int[] arr)
        {
            int n = arr.Length;

            bool[] exists = new bool[n + 1];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] <= n)
                {
                    exists[arr[i]] = true;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (!exists[i])
                {
                    return i;
                }
            }

            return n + 1;

        }
    }
}
