using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class LongestSubArrayWithMaxSum {

    public LongestSubArrayWithMaxSum() 
    {
       FindSumAndSubArray(new int[] {-2, -3, 4, -1, -2, 1, 5, -3});
    }
    
    private void FindSumAndSubArray(int[] nums)
    {
        if (!nums.Any())
        {
            Console.WriteLine("Input array is empty.");
        }
        // Input : {2,-8,3,-2,4}
        Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
        
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            int runningMax = nums[i];
            List<int> runningList = new List<int>();
            runningList.Add(nums[i]);
            
            for (int j = i+1; j <= nums.Length - 1; j++)
            {
                if (nums[i] + nums[j] >= runningMax)
                {
                    runningList.Add(nums[j]);
                    runningMax = Math.Max(runningMax, nums[i] + nums[j]);
                }
                else
                {                    
                    if (!result.TryGetValue(runningMax, out List<int>? currentSubArray))
                    {                        
                        result.Add(runningMax, runningList);
                    }
                    break;
                }
            }
        }
        
        result.Add(nums[nums.Length - 1], new List<int>() {nums[nums.Length - 1]});
        
        //Find the max key in Dictionary
        foreach(int key in result.Select(k => k.Key))
        {
            Console.WriteLine(key);
        }
        
        int? item = result.Select(k => k.Key).OrderByDescending(k => k).FirstOrDefault();
        if (item != null)
        {
            Console.WriteLine($"The max sum is {item.Value} and the sub array is ");
            foreach(int itemValue in result[item.Value])
            {
                Console.WriteLine(itemValue);
            }
        }
    }
}