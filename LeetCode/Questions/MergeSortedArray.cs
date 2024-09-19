using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    internal class MergeSortedArray
    {
        public MergeSortedArray()
        {
            List<int> intList = new List<int>();
            int[] intArr1 = new int[6] { 4, 0, 0, 0, 0, 0 }; //new int[2] { 2, 0 }; //new int[1] { 0 }; //new int[1] { 1 }; //new int[6] { 1, 2, 3, 0, 0, 0 };
            int[] intArr2 = new int[5] { 1, 2, 3, 5, 6 }; //new int[1] { 1 }; //new int[] {}; //new int[3] { 2, 5, 6};

            Merge(intArr1, 1, intArr2, 5);
        }

        private void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            int j = 0;
            if ((m == 0 && n == 0))
            {
                return;
            }

            // m < n
            /*
            * Start with first element in nums1 and check with first element in nums2.
            * If nums1[i] > nums2[j] then 
            ** Push nums1 from i thru length of nums1.
            ** Copy nums2[j] to nums1[i]
            ** Else move nums1 to i+1 position and repeat the above
            ** If i == m then copy nums2[j] thru nums2[length of nums2 - 1] to nums1
            */
            if (m < n)
            {
                while (true)
                {
                    if (i >= nums1.Length || j >= nums2.Length)
                    {
                        break;
                    }

                    if (i == m)
                    {
                        for (int k = i; k < nums1.Length && j < nums2.Length; k++)
                        {
                            nums1[k] = nums2[j];
                            j += 1;
                        }
                    }
                    else if (nums1[i] >= nums2[j] || nums1[i] == 0)
                    {
                        for (int k = nums1.Length - 1; k >= i; k--)
                        {
                            nums1[k] = nums1[k - 1];
                        }
                        nums1[i] = nums2[j];
                        j += 1;
                    }

                    i += 1;
                }
            }
            // m > n
            /*
            *Start with first element in nums1 and check with first element in nums2.
            * If nums1[i] > nums2[j] then
            ** Push nums1 from i thru length of nums1.
            * *Copy nums2[j] to nums1[i]
            **Else move nums1 to i+1 position and repeat the above
            ** If j == n then return nums1
            */
            else if (m > n)
            {
                while (true)
                {
                    if (i >= nums1.Length || j >= nums2.Length || j == n)
                    {
                        break;
                    }
                    else if (nums1[i] >= nums2[j] || nums1[i] == 0)
                    {
                        for (int k = nums1.Length - 1; k >= i; k--)
                        {
                            nums1[k] = nums1[k - 1];
                        }
                        nums1[i] = nums2[j];
                        j += 1;
                    }

                    i += 1;
                }
            }
            // m == n
            else
            {
                while (true)
                {
                    if (i >= nums1.Length || j >= nums2.Length)
                    {
                        break;
                    }

                    if (nums1[i] >= nums2[j] || nums1[i] == 0)
                    {
                        for (int k = nums1.Length - 1; k >= i && k > 0; k--)
                        {
                            nums1[k] = nums1[k - 1];
                        }
                        nums1[i] = nums2[j];
                        j += 1;
                    }
                    i += 1;
                }
            }

            Console.WriteLine();
            for (int r = 0; r < nums1.Length; r++)
            {
                if (r < nums1.Length - 1)
                {
                    Console.Write($"{nums1[r]}, ");
                }
                else
                {
                    Console.Write($"{nums1[r]}");
                }
            }
        }
    }
}
