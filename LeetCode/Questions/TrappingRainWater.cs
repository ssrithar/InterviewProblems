namespace LeetCode.Questions
{
    public class TrappingRainWater
    {
        public TrappingRainWater() 
        {
            //[0,1,0,2,1,0,1,3,2,1,2,1]
            //[4,2,0,3,2,5]

            // TODO: Not solved yet.

            /*
                Iterate thru each element
                If the first and the last elements are 0, meaning no elevation they still wont be able to hold any water.
                Set capacity = 0, maxElevation = 0
                At each element
                    if > 0 then 
                        if (currentElevation > maxElevation) 
                        then 
                            maxElevation = currentElevation
                            capacity = currentElevation
                        else
                            capacity += capacity - currentElevation
                    if == 0 then
                        capacity += maxElevation
                        maxElevation = 0
            */

            Console.WriteLine($"Capacity is {Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 })}");
        }

        public int Trap(int[] height)
        {
            if (!height.Any())
            {
                return 0;
            }

            int capacity = 0;
            int maxElevation = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 0)
                {
                    if (height[i] >= maxElevation)
                    {
                        maxElevation = height[i];
                    }
                    else
                    {
                        capacity = capacity + (maxElevation - height[i]);
                    }
                    Console.WriteLine($"Elevated - height[{i}] is {height[i]}, maxElevation is {maxElevation} and capacity is {capacity}");
                }
                else //height[i] == 0 as height is an array of positive integers
                {
                    if (i != 0 && i < height.Length - 1)
                    {
                        capacity += maxElevation;
                        //maxElevation = 0;
                    }

                    Console.WriteLine($"Not Elevated - height[{i}] is {height[i]}, maxElevation is {maxElevation} and capacity is {capacity}");
                }
            }

            return capacity;
        }
    }
}
