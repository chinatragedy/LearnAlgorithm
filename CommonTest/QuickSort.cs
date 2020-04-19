using System;

namespace CommonTest
{
    public class QuickSort : BaseSort
    {
        public override void Sort(int[] arr)
        {
            base.Sort(arr);

            Partition(arr, 0, arr.Length - 1);
        }

        private int Partition(int[] arr, int begin, int end)
        {
            int pivot = begin;
            int index = begin + 1;
            int x = arr[begin];

            for (int i = begin; i <= end; i++)
            {
                Console.WriteLine($"i:{i} index:{index} value:{x}");
                if (arr[i] < x)
                {
                    swap(arr, i, index);
                    Utils.PrintArray(arr);
                    index++;
                }
            }

            swap(arr, pivot, index - 1);
            Console.WriteLine("-----");
            Utils.PrintArray(arr);
            return index - 1;
        }

        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}