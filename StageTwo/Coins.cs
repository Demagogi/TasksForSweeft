/*გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც
გადაეცემა თანხა (თეთრებში) და აბრუნებს მონეტების მინიმალურ
რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.*/

namespace StageTwo
{
    public static class Coins
    {
        public static int MinSplit(int amount)
        {
            int[] coins = { 50, 20, 10, 5, 1 };
            int minCoins = 0;

            foreach (int coin in coins)
            {
                while (amount >= coin)
                {
                    amount -= coin;
                    minCoins++;
                }
            }

            return minCoins;
        }
    }
}
