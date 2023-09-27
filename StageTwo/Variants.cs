/*გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2
საფეხურით. დაწერეთ ფუნქცია რომელიც დაითვლის n სართულზე ასვლის
ვარიანტების რაოდენობას.*/

namespace StageTwo
{
    public static class Variants
    {
        public static int CountVariants(int stairCount)
        {
            if (stairCount <= 1)
            {
                return 1; 
            }

            return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
        }
    }
}
