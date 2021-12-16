using System;

namespace Stairs_countVariants
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Input the amount of stairs ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"All possible variants for reaching stair number {n}" +
                    $" with only one or double stair steps are:  {countVariants(n)}");
        }

        static int countVariants(int stairsCount)
        {
            int[] res = new int[stairsCount + 1];
            int temp = 0;
            res[0] = 1;

            for(int i = 1; i <= stairsCount; ++i)
            {
                int two = i - 3;
                int one = i - 1;
                if (two >= 0)
                {
                    temp -= res[two];
                }
                temp += res[one];
                res[i] = temp;
            }
            return res[stairsCount];
        }
    }
}
