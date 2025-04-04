public class ThreeSum
{
    public ThreeSum()
    {
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        var result = FindThreeSum(nums);
        Console.WriteLine("Three Sum Results: ");
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }

    public IList<IList<int>> FindThreeSum(int[] nums)
    {
        if (nums.Length == 0)
        {
            return new List<IList<int>>();
        }

        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicates for the first number

            // Two pointers for the second and third numbers
            int current = nums[i];
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right] + current;
                if (sum == 0)
                {
                    result.Add(new List<int> { current, nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}