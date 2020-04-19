using System;

namespace CommonTest
{
    class Program
    {
        // static int[] arr = {38, 3, 5, 44, 48, 15, 36, 26, 50, 27, 2, 46, 4, 19, 47, 99};
        static int[] arr = {38, 3, 5, 44, 4, 19, 47, 2};

        static void Main(string[] args)
        {
            // Console.WriteLine("- Sort Begin! -");
            Console.WriteLine("- Before Sort");
            Utils.PrintArray(arr);
            Console.WriteLine("- After Sort");

            BaseSort sorter;

            // sorter = new BubbleSort();    //冒泡排序
            // sorter = new SelectionSort(); //选择排序
            // sorter = new InsertionSort(); //插入排序
            // sorter = new ShellSort();         //插入排序
            // sorter = new MergeSort();         //归并排序
            sorter = new QuickSort();         //快速排序

            sorter.Sort(arr);
        }
    }
}