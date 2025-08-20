namespace InterviewProblems.DataStructures
{
    public class ArrayProblems
    {
        int[] items = new int[5];

        public ArrayProblems()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = i;
            }
            PrintArray();

            AddElementToDynamicArray(6);
            PrintArray();
        }

        public void AddElementToDynamicArray(int element)
        {
            if (items.Count() == items.Length)
            {
                int[] newItems = new int[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newItems[i] = items[i];
                }
                newItems[items.Length] = element;
                items = newItems;
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        // Problem: Find the maximum sum of a subarray of a given size.
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        public static int MaxSumSubarray(int[] arr, int k)
        {
            int maxSum = 0;
            int windowSum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];

                if (windowEnd >= k - 1)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                    windowSum -= arr[windowStart];
                    windowStart++;
                }
            }

            return maxSum;
        }
    }
}