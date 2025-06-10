namespace LeetCode.Questions
{
    public class MajorityElements
    {
        public MajorityElements()
        {
            int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
        }
        public int MajorityElement(int[] nums)
        {
            int count = 0, candidate = 0;
            foreach (var num in nums)
            {
                if (count == 0) candidate = num;
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}