public class MaxDistanceClosePerson
{

    public MaxDistanceClosePerson()
    {
        var result = MaxDistToSeat(new int[] { 1, 0, 0, 0, 1, 0, 1 });
        Console.WriteLine(result);
    }

    public int MaxDistToClosest(int[] seats)
    {
        int n = seats.Length;
        int maxDistance = 0;
        int lastOccupied = -1;

        for (int i = 0; i < n; i++)
        {
            if (seats[i] == 1)
            {
                if (lastOccupied == -1)
                {
                    // If this is the first occupied seat, calculate distance from the start
                    maxDistance = Math.Max(maxDistance, i);
                }
                else
                {
                    // Calculate distance from the last occupied seat
                    int distance = (i - lastOccupied) / 2;
                    maxDistance = Math.Max(maxDistance, distance);
                }
                lastOccupied = i;
            }
        }

        // Check distance from the last occupied seat to the end of the row
        if (lastOccupied != -1)
        {
            maxDistance = Math.Max(maxDistance, n - 1 - lastOccupied);
        }

        return maxDistance;
    }

    /// <summary>
    /// LeetCode: Maximize Distance to Closest Person
    /// For each seat, calculate the distance to the nearest occupied seat in both directions.
    /// Select the maximum of these two distances. 
    /// Divide that distance by 2.
    /// Store it as the maximum distance along with the index of the seat.
    /// Set the seat as occupied in the seats array.
    /// Repeat for each seat.
    /// </summary>
    /// <param name="seats"></param>
    /// <returns></returns>
    public int MaxDistToSeat(int[] seats)
    {
        if (seats == null || seats.Length == 0)
        {
            return 0;
        }

        int n = seats.Length;
        List<int> occupiedSeats = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (seats[i] == 1)
            {
                occupiedSeats.Add(i);
            }
        }

        int maxDistance = 0;
        
        for (int j = 0; j < occupiedSeats.Count; j++)
        {
            int occupiedIndex = occupiedSeats[j];
            if (j == 0)
            {
                // Calculate distance from the start of the row to the first occupied seat
                maxDistance = Math.Max(maxDistance, occupiedIndex) / 2;
            }
            else if (j == occupiedSeats.Count - 1)
            {
                // Calculate distance from the last occupied seat to the end of the row
                maxDistance = Math.Max(maxDistance, n - 1 - occupiedIndex);
            }
            else
            {
                // Calculate distance between two occupied seats
                int distance = Math.Max(occupiedIndex - occupiedSeats[j-1], occupiedSeats[j+1] - occupiedIndex) / 2;  
                maxDistance = Math.Max(maxDistance, distance);              
            }
        }

        return maxDistance;
    }
}