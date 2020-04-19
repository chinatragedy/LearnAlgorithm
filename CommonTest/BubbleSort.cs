namespace CommonTest
{
    public class BubbleSort: BaseSort
    {
        override 
        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
            base.Sort(arr);
        }
    }
}