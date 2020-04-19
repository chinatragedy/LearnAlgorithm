using System;

namespace CommonTest
{
    public class Utils
    {
        public static void PrintArray(int[] arr, string title = "")
        {
            String ss = String.Join(",", arr);
            Console.WriteLine($"{title}[ {ss} ]");
        }
    }
}