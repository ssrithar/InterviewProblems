namespace LeetCode.Questions
{
    public class RemoveDuplicates
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
        public RemoveDuplicates()
        {
            printNums(0, nums);
            //this.RemoveDups(nums);            
            this.RemoveDupsInPlace(nums);
            printNums(0, nums);
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

        public void RemoveDupsInPlace(int[] nums)
        {
            HashSet<int> uniqueValues = new HashSet<int>();

            int uniqueValueEndIndex = nums.Length - 1;
            int i = 0;
            while (i < uniqueValueEndIndex)
            {
                if (uniqueValues.Contains(nums[i]))
                {
                    int temp = nums[i];
                    nums[i] = nums[uniqueValueEndIndex];
                    nums[uniqueValueEndIndex] = temp;
                    uniqueValueEndIndex--;
                }
                else
                {
                    uniqueValues.Add(nums[i]);
                    i++;
                }
            }

            Console.WriteLine($"Unique elements are in the index range 0 thru {--uniqueValueEndIndex}");
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