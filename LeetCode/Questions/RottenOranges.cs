public class RottenOranges
{
    public RottenOranges()
    {
        int[][] grid1 = new int[][] {
            // new int[] { 2, 1, 1 },
            // new int[] { 1, 1, 0 },
            // new int[] { 0, 1, 1 }
            new int[] {0, 2}
        };

        Console.WriteLine($"Rotten Oranges 1: {OrangesRotting2(grid1)}"); // Output: 4
    }

    public int OrangesRotting(int[][] grid)
    {
        if (grid == null || grid.Length == 0 || grid[0].Length == 0) return -1;

        int rows = grid.Length;
        int cols = grid[0].Length;
        int freshCount = 0;
        Queue<(int, int)> queue = new Queue<(int, int)>();
        // Count fresh oranges and add rotten oranges to the queue
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    freshCount++;
                }
                else if (grid[i][j] == 2)
                {
                    queue.Enqueue((i, j));
                }
            }
        }
        if (freshCount == 0) return 0; // No fresh oranges to rot
        if (queue.Count == 0) return -1; // No rotten oranges to start with
        int minutes = 0;
        // Directions for adjacent cells (up, down, left, right)
        int[][] directions = new int[][] { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
        // BFS to rot adjacent fresh oranges
        while (queue.Count > 0)
        {
            int size = queue.Count;
            bool hasRotten = false; // Track if any fresh orange rots in this minute
            for (int i = 0; i < size; i++)
            {
                var (x, y) = queue.Dequeue();
                foreach (var dir in directions)
                {
                    int newX = x + dir[0];
                    int newY = y + dir[1];
                    if (newX >= 0 && newX < rows && newY >= 0 && newY < cols && grid[newX][newY] == 1)
                    {
                        grid[newX][newY] = 2; // Rot the fresh orange
                        freshCount--;
                        queue.Enqueue((newX, newY));
                        hasRotten = true; // At least one fresh orange rotted
                    }
                }
            }
            if (hasRotten) minutes++; // Only increment minutes if at least one orange rotted
        }
        return freshCount == 0 ? minutes : -1; // If all fresh oranges are rotten, return minutes; otherwise, return -1
    }

    public int OrangesRotting2(int[][] grid)
    {
        int rowSize = grid.Length;
        int colSize = grid[0].Length;
        
        if (grid == null ||
            rowSize == 0 ||
            colSize == 0
        )
        {
            return -1;
        }

        // Find rotten orange cells and add it to a Queue. Also check for fresh oranges, if none, then return -1
        var queue = new Queue<(int, int)>();
        int freshCount = 0;
        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < colSize; j++)
            {
                if (grid[i][j] == 1)
                {
                    freshCount += 1;
                }
                else if (grid[i][j] == 2)
                {
                    queue.Enqueue((i, j));
                }
            }
        }

        if (freshCount == 0 || queue.Count == 0) return -1;

        int minutes = -1;
        while (queue.Count > 0)
        {
            bool didRot = false;
            var (x, y) = queue.Dequeue();
            
            if ((x - 1) >= 0 && grid[x-1][y] == 1)
            {
                grid[x-1][y] = 2;
                queue.Enqueue((x-1, y));
                freshCount -= 1;
                didRot = true;
            }
            if ((x + 1) < rowSize && grid[x+1][y] == 1)
            {
                grid[x+1][y] = 2;
                queue.Enqueue((x+1, y));
                freshCount -= 1;
                didRot = true;
            }
            if ((y - 1) >= 0 && grid[x][y-1] == 1)
            {
                grid[x][y-1] = 2;
                queue.Enqueue((x, y-1));
                freshCount -= 1;
                didRot = true;
            }
            if (y+1 < colSize && grid[x][y+1] == 1)
            {
                grid[x][y+1] = 2;
                queue.Enqueue((x, y+1));
                freshCount -= 1;
                didRot = true;
            }
            
            if (didRot)
            {
                minutes += 1;
            }
        }

        if (freshCount > 0) return -1;

        return minutes;
    }
} 