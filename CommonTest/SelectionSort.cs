namespace CommonTest
{
    public class SelectionSort : BaseSort
    {
        override 
        public void Sort(int[] arr)
        {
            int minIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            
            base.Sort(arr);
        }
    }
}