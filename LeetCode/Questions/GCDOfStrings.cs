using System.Text;

namespace LeetCode.Questions
{
    public class GCDOfStrings
    {
        public GCDOfStrings()
        {
            var result = GcdOfStrings("ABCABC", "ABC");
            Console.WriteLine(result);
        }

        public string GcdOfStrings(string str1, string str2)
        {
            if (string.Equals(str1, str2))
            {
                return str2;
            }

            if (str1.Length < str2.Length)
            {
                return string.Empty;
            }
            else
            {
                if (!str1.Contains(str2))
                {
                    return string.Empty;
                }

                StringBuilder str2Temp = new StringBuilder();
                for (int i = 1; i <= str1.Length / str2.Length; i++)
                {
                    str2Temp.Append(str2);
                }

                if (string.Equals(str1, str2Temp.ToString()))
                {
                    return str2;
                }

                return string.Empty;
            }
        }
    }
}