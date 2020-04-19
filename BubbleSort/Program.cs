using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort Bubble Sort");
            int[] arr = {3, 38, 5, 44, 48, 15, 36, 26, 50, 27, 2, 46, 4, 19, 47, 99};
            Sort(arr);
        }

        static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j - 1];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine($"@zjh {arr.ToString()}");
        }
    }
}