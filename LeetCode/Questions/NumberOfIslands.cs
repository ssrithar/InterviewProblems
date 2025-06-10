namespace LeetCode.Questions
{
    public class NumberOfIslands
    {
        public NumberOfIslands()
        {
            
        }

        public int NumIslands(char[][] grid) 
        {
            List<(int, int)> directions = new List<(int, int)>() {(0, -1), (0, 1), (-1, 0), (1, 0)};
            
            bool[][] visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                visited[i] = new bool[grid[0].Length];
            }

            

            return 0;
        }
    }
}