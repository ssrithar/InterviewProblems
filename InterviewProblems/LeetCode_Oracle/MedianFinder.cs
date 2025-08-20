using System.Security.Principal;

namespace InterviewProblems.LeetCode_Oracle
{
    public class MedianFinder
    {
        PriorityQueue<int, int> low;
        PriorityQueue<int, int> high;

        PriorityQueue<int, int> low1;

        PriorityQueue<int, int> high1;

        public MedianFinder()
        {
            low = new PriorityQueue<int, int>();
            low1 = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            high = new PriorityQueue<int, int>();
            high1 = new PriorityQueue<int, int>();

            AddNum(1);
            AddNum(2);
            Console.WriteLine(FindMedian());
            AddNum(3);
            Console.WriteLine(FindMedian());
            AddNum(4);
            Console.WriteLine(FindMedian());

            // Console.WriteLine("Logic 2");
            // AddNum1(1);
            // AddNum1(2);
            // Console.WriteLine(FindMedian1());
            // AddNum1(3);
            // Console.WriteLine(FindMedian1());
            // AddNum1(4);
            // Console.WriteLine(FindMedian1());
        }

        public void AddNum(int num)
        {
            if (high.Count == 0 || num < -high.Peek())
            {
                high.Enqueue(-num, -num);
            }
            else
            {
                low.Enqueue(num, num);
            }

            if (high.Count > low.Count + 1)
            {
                int val = high.Dequeue();
                low.Enqueue(val, val);
            }
            else if (low.Count > high.Count)
            {
                int val = low.Dequeue();
                high.Enqueue(-val, -val);
            }
        }

        public double FindMedian()
        {
            if (high.Count > low.Count)
            {
                return -high.Peek();
            }
            else
            {
                return (-high.Peek() + low.Peek()) / 2.0;
            }
        }

        public void AddNum1(int num)
        {
            int val;

            low1.Enqueue(num, num);
            val = low1.Dequeue();
            high1.Enqueue(val, val);

            if (low1.Count < high1.Count)
            {
                val = high1.Dequeue();
                low1.Enqueue(val, val);
            }
        }

        public double FindMedian1()
        {
            if (low1.Count > high1.Count) return low1.Peek();

            return (low1.Peek() + high1.Peek()) / 2.0;
        }
    }
}