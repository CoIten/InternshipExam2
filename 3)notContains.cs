using System;

namespace notContainedMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 4, 2, 4, 5, 9, -2, 1, 3 };
            Console.WriteLine($"\n The smallest missing integer from the array is:  {notContains(myArray)}");

        }


        static int notContains(int[] array)
        {
            
            for(int i = 0; i < array.Length; ++i)
            {

                //Traversing the array and swapping elements
                while (array[i] >= 1 && array[i] <= array.Length
                    && array[i] != array[array[i]-1])
                {
                    int temp = array[array[i] - 1];
                    array[array[i] - 1] = array[i];
                    array[i] = temp;
                }
            }

            //Finding an element that is not equal to its expected index
            for (int i = 0; i < array.Length; ++i)
                if (array[i] != i + 1)
                    return (i + 1);

            //In case array includes all
            //integers to the array length
            return (array.Length + 1);

        }

    }
}
