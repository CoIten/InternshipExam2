using System;

namespace minSplitFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Find out minimum amount of coins needed to convert certain amount of money: ");
            int[] coins = { 1, 5, 10, 20, 50 };
            Console.WriteLine(" Input amount ");
            int Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Minimum amount of coins needed is {minSplit(Amount, coins)} ");
        }

        static int minSplit(int amount, int[] coins)
        {
            
            // Creating table for storing minimum amount of coins for i value
            int[] table = new int[amount + 1];
            table[0] = 0;
            for (int i = 1; i <= amount; ++i)
                table[i] = int.MaxValue;

            for (int i = 1; i <= amount; ++i)
            {
                // Going through all coins that are smaller than i
                for (int j = 0; j < coins.Length; ++j)
                    if (coins[j] <= i)
                    {
                        int sub_result = table[i - coins[j]];
                        if (sub_result != int.MaxValue && sub_result + 1 < table[i])
                            table[i] = sub_result + 1;
                    }
            }
            return table[amount];

        }
    }
}
