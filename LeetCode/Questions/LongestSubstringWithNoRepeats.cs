namespace LeetCode.Questions
{
    public class LongestSubstringWithNoRepeats
    {
        public LongestSubstringWithNoRepeats()
        {
            var string1 = "abcabcbb";
            var string2 = "bbbbb";
            var string3 = "pwwkew";

            Console.WriteLine(LengthOfLongestSubstring(string1));
        }

        private int GetLengthOfNonRepeatingSubString(string s)
        {
            int stringLength = s.Length;

            if (stringLength <= 0)
            {
                return -1;
            }

            int i = 0;
            int lengthOfSubstring = 0;
            while (i <= stringLength)
            {
                Dictionary<string, int> charCount = new Dictionary<string, int>();
                int lengthOfCurrentSubstring = 0;

                for (int j = i; j < stringLength; j++)
                {
                    //Console.WriteLine($"{s} {j}");
                    var currentChar = s.Substring(j, 1);
                    //Console.WriteLine($"Current Char is {currentChar}");
                    if (!charCount.TryGetValue(currentChar, out int currentCharCount))
                    {
                        charCount.Add(currentChar, 1);
                        lengthOfCurrentSubstring += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                //foreach (var item in charCount)
                //{
                //	Console.WriteLine($"{item.Key} {item.Value}");
                //}

                //Console.WriteLine($"The Length of CurrentSubstring {String.Join("", charCount.Select(c => c.Key).ToArray())} is {lengthOfCurrentSubstring}");

                if (lengthOfCurrentSubstring >= lengthOfSubstring)
                {
                    lengthOfSubstring = lengthOfCurrentSubstring;
                }

                i += 1;
            }

            Console.WriteLine($"The final of the non repeating sub string is {lengthOfSubstring}");
            return lengthOfSubstring;
        }

        private int LengthOfLongestSubstring(string s)
        {
            var charSet = new HashSet<char>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left++]);
                }

                charSet.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
