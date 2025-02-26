public class GroupAnagrams
{
    public GroupAnagrams()
    {
        string[] strings = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result = FindAndGroupAnagrams(strings);
        foreach (var group in result)
        {
            Console.WriteLine(string.Join(", ", group));
        }
    }

    public IList<IList<string>> FindAndGroupAnagrams(string[] strings)
    {
        var anagrams = new Dictionary<string, List<string>>();

        foreach (var str in strings)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new string(charArray);

            if (!anagrams.ContainsKey(sortedStr))
            {
                anagrams[sortedStr] = new List<string>();
            }
            anagrams[sortedStr].Add(str);
        }

        return [.. anagrams.Values];
    }
}