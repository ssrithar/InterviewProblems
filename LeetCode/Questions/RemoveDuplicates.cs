namespace LeetCode.Questions
{
    public class RemoveDuplicates
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
        public RemoveDuplicates()
        {
            printNums(0, nums);
            this.RemoveDups(nums);            
        }

        public int RemoveDups(int[] nums)
        {
            if (nums.Length <= 2) return nums.Length;
            int j = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[j - 2])
                {
                    nums[j++] = nums[i];
                }

                printNums(i, nums);
            }
            return j;
        }

        public void printNums(int counter, int[] nums)
        {
            Console.WriteLine($"Counter {counter}");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Counter {counter}");        
        }
    }
}