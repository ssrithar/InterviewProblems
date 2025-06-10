namespace InterviewProblems
{
    public class PriorityQueues
    {
        public PriorityQueues()
        {
            KthLargestElement();
        }

        private void KthLargestElement()
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            int k = 2;
            for (int i = 0; i < 10; i++)
            {
                priorityQueue.Enqueue(i+1, i+1);
                if (i > k)
                {
                    priorityQueue.Dequeue();
                }
            }
            Console.WriteLine($"{k}th largest value is {priorityQueue.Peek()}");
        }

        private void BasicPriorityQueue()
        {
            PriorityQueue<int, int> priorityQueue = new System.Collections.Generic.PriorityQueue<int, int>(3);
            
            try
            {
                priorityQueue.Enqueue(1, -100);
                priorityQueue.Enqueue(2, 20);
                priorityQueue.Enqueue(3, 3);

                while (priorityQueue.Count > 0)
                {
                    Console.WriteLine(priorityQueue.Dequeue());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}