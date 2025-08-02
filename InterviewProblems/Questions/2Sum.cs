// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

public class TwoSum
{
    public TwoSum()
    {
        int[] arr = new int[] { 1, 3, 5, 7, 9 };
        arr = new int[] { 1, 3, 5, 5, 7, 9, 1, 9 };
        Console.WriteLine(string.Join(", ", FindTwoSum(arr, 10)));

        FindAllTwoSums(arr, 10).ForEach(item =>
        {
            Console.WriteLine($"{item[0]}, {item[1]}");
        });
    }

    /// <summary>
    /// This finds the first pair of indexes that yield the target.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    private int[] FindTwoSum(int[] nums, int target)
    {
        // Input validation
        if (nums.Length <= 0)
            return new int[] { };

        Dictionary<int, int> numsAndIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (numsAndIndex.ContainsKey(difference))
                return new int[] { numsAndIndex[difference], i };
            else
                numsAndIndex.Add(nums[i], i);
        }

        return new int[] { };
    }

    /// <summary>
    /// This misses the cases where there are duplicate values in the array that yield the target.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    private List<int[]> FindAllTwoSums(int[] nums, int target)
    {
        // Input validation
        if (nums.Length <= 0)
            return new List<int[]>();

        List<int[]> result = new List<int[]>();

        Dictionary<int, int> numsAndIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (numsAndIndex.ContainsKey(difference))
                result.Add(new int[] { numsAndIndex[difference], i });
            else
                numsAndIndex.Add(nums[i], i);
        }

        return result;
    }

    /// <summary>
    /// Find all pairs of indexes that yield the target, where the input array has dups.
    /// The solution will be a O(n^2)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    private List<List<int[]>> FindAllTwoSumsWithDups(int[] nums, int target)
    {
        Dictionary<int, List<int[]>> result = new Dictionary<int, List<int[]>>();
        Dictionary<int, int> numsAndIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (numsAndIndex.ContainsKey(difference))
            {
                result[difference].Add(new int[] { numsAndIndex[difference], i });
                numsAndIndex.Remove(difference);
            }
            else
            {
                numsAndIndex.Add(difference, i);
            }
        }

        return result.Select(item => item.Value).ToList();
    }
}