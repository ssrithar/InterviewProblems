namespace LeetCode.Questions
{
    public class ListNode1
    {
        public int val;
        public ListNode1 next;

        public ListNode1(int val = 0, ListNode1 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MergeKSortedLists
    {
        public MergeKSortedLists()
        {
            var lists = new ListNode1[]
            {
                CreateList(new int[] {1, 4, 5}),
                CreateList(new int[] {1, 3, 4}),
                CreateList(new int[] {2, 6})
            };

            var sortedListHead = mergeSortedLists(lists);

            while (sortedListHead != null)
            {
                Console.WriteLine(sortedListHead.val);
                sortedListHead = sortedListHead.next;
            }
        }

        public ListNode1 mergeSortedLists(ListNode1[] lists)
        {
            if (!lists.Any())
            {
                return null;
            }

            PriorityQueue<ListNode1, int> priorityQueue = new PriorityQueue<ListNode1, int>();
            ListNode1 start = new ListNode1();
            ListNode1 current = start;

            foreach (var node in lists)
            {
                if (node != null) priorityQueue.Enqueue(node, node.val);
            }

            while (priorityQueue.Count > 0)
            {
                var smallest = priorityQueue.Dequeue();
                if (smallest != null)
                {
                    current.next = smallest;
                    current = current.next;
                }

                if (smallest.next != null) priorityQueue.Enqueue(smallest.next, smallest.next.val);
            }

            return start;
        }

        private ListNode1 CreateList(int[] values)
        {
            ListNode1 dummy = new ListNode1();
            ListNode1 current = dummy;
            foreach (var val in values)
            {
                current.next = new ListNode1(val);
                current = current.next;
            }
            return dummy.next;
        }
    }
}