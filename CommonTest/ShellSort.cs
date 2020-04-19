using System;

namespace CommonTest
{
    public class ShellSort : BaseSort
    {
        public override void Sort(int[] arr)
        {
            int length = arr.Length;
            for (int gap = length / 2; gap > 0; gap = gap / 2)
            {
                Console.WriteLine("-- gap:" + gap);
                for (int i = gap; i < length; i++)
                {
                    int preIndex = i - gap;
                    int current = arr[i];
                    while (preIndex >= 0 && arr[preIndex] > current)
                    {
                        arr[preIndex + gap] = arr[preIndex];
                        preIndex -= gap;
                    }

                    arr[preIndex + gap] = current;

                    Console.WriteLine("--- i:" + i);
                    Utils.PrintArray(arr);
                }
            }

            base.Sort(arr);
        }
    }
}