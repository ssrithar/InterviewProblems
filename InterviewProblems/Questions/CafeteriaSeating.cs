namespace InterviewProblems.Questions
{
    public class CafeteriaSeating
    {
        public CafeteriaSeating()
        {
            //Console.WriteLine(getMaxAdditionalDinersCount(10, 1, 2, [2, 6]));
            Console.WriteLine(getMaxAdditionalDinersCount(15, 2, 3, [11, 6, 14]));
        }

        public long getMaxAdditionalDinersCount(long N, long K, int M, long[] S)
        {
            // Write your code here
            if (N == 0 || K == 0 || M == 0 || S.Length == 0 || N == M || K == M)
            {
                return 0L;
            }

            List<long> S1 = [.. S];
            long maxDiners = 0L;

            //for each occupied seat go k-1 and k+1 seats (left and right) to see if they are empty
            //if they are empty, add them to the maxDiners count
            for (int i = 0; i < S.Length; i++)
            {
                long leftSeat = S[i] - K - 1;
                long rightSeat = S[i] + K + 1;

                long leftMargin = i > 0 ? S[i - 1] : 0;
                while (leftSeat >= leftMargin)
                {
                    if (leftSeat >= 0 && leftSeat <= S[i] && !S1.Contains(leftSeat))
                    {
                        maxDiners++;
                        S1.Add(leftSeat);
                    }
                    if (leftSeat - K - 1 >= 0 && !S1.Contains(leftSeat - K - 1))
                    {
                        maxDiners++;
                        S1.Add(leftSeat - K - 1);
                    }
                    leftSeat = leftSeat - K - 1;
                }

                long rightMargin = i < S.Length - 1 ? S[i + 1] : N - 1;
                while (rightSeat <= rightMargin)
                {                    
                    if (rightSeat >= S[i] && rightSeat <= rightMargin && !S1.Contains(rightSeat))
                    {
                        maxDiners++;
                        S1.Add(rightSeat);
                    }
                    if (rightSeat + K + 1 <= rightMargin && !S1.Contains(rightSeat + K + 1))                    
                    {
                        maxDiners++;
                        S1.Add(rightSeat + K + 1);
                    }
                    rightSeat = rightSeat + K + 1;
                }
            }

            return maxDiners;
        }
    }
}