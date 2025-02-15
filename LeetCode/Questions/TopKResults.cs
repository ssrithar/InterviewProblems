public class TopKResults
{
    public TopKResults()
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int k = 2;

        var result = TopKFrequent(nums, k);
        Console.WriteLine($"The top {k} frequent elements are: {string.Join(", ", result)}");

        Console.WriteLine($"The top {k} frequent elements using LINQ are: {string.Join(", ", nums.GroupBy(x => x).OrderByDescending(g => g.Count()).Take(k).Select(g => g.Key))}");
    }

    public IList<int> TopKFrequent(int[] nums, int k)
    {
        var frequencyMap = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        var sortedFrequency = frequencyMap.OrderByDescending(x => x.Value).ToList();
        return sortedFrequency.Take(k).Select(x => x.Key).ToList();
    }
}