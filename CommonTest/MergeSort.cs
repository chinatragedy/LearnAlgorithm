using System;

namespace CommonTest
{
    public class MergeSort : BaseSort
    {
        public override void Sort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            mergeSort(arr, 0, arr.Length - 1, temp);
            base.Sort(temp);
        }

        private void mergeSort(int[] arr, int first, int last, int[] temp)
        {
            if (first < last)
            {
                int mid = (last + first) / 2;

                mergeSort(arr, first, mid, temp);
                mergeSort(arr, mid + 1, last, temp);
                mergeArray(arr, first, mid, last, temp);
            }
        }

        private void mergeArray(int[] arr, int first, int mid, int last, int[] temp)
        {
            int i = first;
            int j = mid + 1;
            int k = 0;
            while (i <= mid && j <= last)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= last)
            {
                temp[k++] = arr[j++];
            }

            k = 0;

            while (first <= last)
            {
                arr[first++] = temp[k++];
            }
        }
    }
}