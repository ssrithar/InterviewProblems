public class CountOfSubsets
{
    public CountOfSubsets()
    {
        IList<int> nums = new List<int> { 2,1,4,2,7 };
        int l = 1;
        int r = 5;
        Console.WriteLine($"Count of Subsets: {CountSubMultisets2(nums, l, r)}");
    }

    public int CountSubMultisets(IList<int> nums, int l, int r)
    {
        int count = 0;

        void FindSubsets(int index, int currentSum)
        {
            if (index == nums.Count)
            {
                if (currentSum >= l && currentSum <= r)
                {
                    count++;
                }
                return;
            }

            // Include the current element
            FindSubsets(index + 1, currentSum + nums[index]);

            // Exclude the current element
            FindSubsets(index + 1, currentSum);
        }

        FindSubsets(0, 0);
        return count;
    }

    public int CountSubMultisets2(IList<int> nums, int l, int r) {
        if (nums.Count == 0)
        {
            return -1;
        }

        var items = nums.ToList();
        items.Sort();

        int count = 0;

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] >= l && items[i] <= r)
            {
                count++;
            }
            else if (items[i] > r)
            {
                continue;
            }

            if (i > 0 && items[i] == items[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int sum = 0;
            while (left < items.Count - 1)
            {
                sum = items[i] + items[left];
                if (sum >= l && sum <= r)
                {
                    count++;
                }

                left++;
            }            
        }

        return count;
    }
}