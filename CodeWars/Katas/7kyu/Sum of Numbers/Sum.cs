namespace CodeWars.Katas._7kyu.Sum_of_Numbers
{
    /// <summary>
    ///
    /// Given two integers a and b, which can be positive or negative, find the sum of all
    /// the numbers between including them too and return it. If the two numbers are equal return a or b.
    /// Note: a and b are not ordered!
    ///
    /// Examples:
    /// GetSum(1, 0) == 1   // 1 + 0 = 1
    /// GetSum(1, 2) == 3   // 1 + 2 = 3
    /// GetSum(0, 1) == 1   // 0 + 1 = 1
    /// GetSum(1, 1) == 1   // 1 Since both are same
    /// GetSum(-1, 0) == -1 // -1 + 0 = -1
    /// GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2
    ///
    /// </summary>

    public class Sum
    {
        public static int GetSum(int a, int b)
        {
            if (a == b) return a;

            int result = 0;

            int lowest = a < b ? a : b;
            int highest = lowest == a ? b : a;

            for (int i = lowest; i < highest + 1; i++)
            {
                result += i;
            }

            return result;
        }
    }
}