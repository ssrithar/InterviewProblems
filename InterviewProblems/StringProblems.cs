using System.Text;

namespace InterviewProblems
{
    public class StringProblems
    {
        public StringProblems()
        {
            Console.WriteLine("Zebra-493?");
            Console.WriteLine(CipherString("Zebra-493?", 3));
        }

        public string CipherString(string input, int rotationFactor)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    sb.Append((char)((c + rotationFactor - offset) % 26 + offset));
                }
                else if (char.IsDigit(c))
                {
                    sb.Append(((int.Parse(c.ToString()) + rotationFactor) % 10).ToString());
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    
        public string MatchPairs(string s, string t)
        {
            return "";
        }
    }
}