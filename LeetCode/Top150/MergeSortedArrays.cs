namespace LeetCode.Top150
{
    /*
        You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        Merge nums1 and nums2 into a single array sorted in non-decreasing order.

        The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

        

        Example 1:

        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        Example 2:

        Input: nums1 = [1], m = 1, nums2 = [], n = 0
        Output: [1]
        Explanation: The arrays we are merging are [1] and [].
        The result of the merge is [1].
        Example 3:

        Input: nums1 = [0], m = 0, nums2 = [1], n = 1
        Output: [1]
        Explanation: The arrays we are merging are [] and [1].
        The result of the merge is [1].
        Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
        

        Constraints:

        nums1.length == m + n
        nums2.length == n
        0 <= m, n <= 200
        1 <= m + n <= 200
        -109 <= nums1[i], nums2[j] <= 109
        

        Follow up: Can you come up with an algorithm that runs in O(m + n) time?
    */
    public class MergeSortedArrays
    {
        public MergeSortedArrays()
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;

            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;

            Merge(nums1, m, nums2, n);
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            /*
            Logic
            - Start with one pointer for each of the arrays at the end of the numbers.
            - Create a pointer at the real end of the nums1 array for position to write.
            - Check the values at the end of the actual data indexes in each array.
                - If nums1 value is greater than nums2 value, then move nums1 value to write pointer index. 
                    - Decrease the pointer index.
                    - Decrease the nums1 pointer.
                - Else write the nums2 value in the write pointer index.
                    - Decrease the pointer index.
                    - Decrease the nums2 pointer.
            - Repeat above until nums2 pointer is 0
            */

            int i = m + n - 1;
            m = m - 1; // Zero based index
            n = n - 1; // Zero based index

            while (n >= 0)
            {
                if (m >= 0 && nums1[m] >= nums2[n])
                {
                    nums1[i] = nums1[m];
                    m -= 1;
                }
                else
                {
                    nums1[i] = nums2[n];
                    n -= 1;
                }
                i -= 1;         
            }

            Console.WriteLine("Sorted");
            Array.ForEach(nums1, item => Console.Write($"{item} "));
        }
    }
}