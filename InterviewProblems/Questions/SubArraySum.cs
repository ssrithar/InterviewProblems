// Given an array of integers and an integer k, find the total number of continuous subarrays whose sum equals to k.

public class SubArraySum
{
    public SubArraySum()
    {
        //int[] nums = { 1, 2, 3, 7, 5 };
        int[] nums = { 3, 4, -2, 1, 6, -3, 2, 5 };
        int target = 7;

        GetContiguousIndex(nums, target).ToList().ForEach(item =>
        {
            Console.WriteLine(item);
        });

        Console.WriteLine($"Count of contiguous subarrays that sum to {target} is {SubarraySum(nums, target)}");
    }

    private int[] GetContiguousIndex(int[] nums, int target)
    {
        if (nums.Length == 0) return new int[] { };

        int i = 0;
        int interimSum = nums[i];

        if (interimSum == target) return new int[] { i };

        List<int> sumIndexes = new List<int>();
        sumIndexes.Add(i);

        int j = 1;
        while (i < nums.Length && j < nums.Length)
        {
            interimSum += nums[j];
            if (interimSum == target)
            {
                sumIndexes.Add(j);
                break;
            }
            else if (interimSum < target)
            {
                j++;
            }
            else
            {
                i++;
                j = i + 1;
                sumIndexes.Clear();
                sumIndexes.Add(i);
                sumIndexes.Add(j);
                interimSum = nums[i];
            }
        }

        return sumIndexes.ToArray();
    }

    public int SubarraySum(int[] nums, int k)
    {
        int count = 0;
        int prefixSum = 0;
        var prefixMap = new Dictionary<int, int>();
        prefixMap[0] = 1; // Initialize with sum 0 seen once

        foreach (int num in nums)
        {
            prefixSum += num;

            if (prefixMap.ContainsKey(prefixSum - k))
            {
                count += prefixMap[prefixSum - k];
            }

            if (prefixMap.ContainsKey(prefixSum))
            {
                prefixMap[prefixSum]++;
            }
            else
            {
                prefixMap[prefixSum] = 1;
            }
        }

        return count;
    }
}