namespace CommonTest
{
    public class InsertionSort : BaseSort
    {
        public override void Sort(int[] arr)
        {
            int preIndex, curt;
            for (int i = 1; i < arr.Length; i++)
            {
                preIndex = i - 1;
                curt = arr[i];
                while (preIndex >= 0 && arr[preIndex] > curt)
                {
                    arr[preIndex + 1] = arr[preIndex];
                    preIndex--;
                }

                arr[preIndex + 1] = curt;
            }

            base.Sort(arr);
        }
    }
}