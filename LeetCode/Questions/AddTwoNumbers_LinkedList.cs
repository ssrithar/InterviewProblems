namespace LeetCode.Questions
{
    public class AddTwoNumbers_LinkedList
    {
        public AddTwoNumbers_LinkedList() 
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            var result = AddTwoNumbers(l1, l2);
            string resultString = string.Empty;
            while (result != null)
            {
                resultString = $"{result.val}{resultString}";
                result = result.next;
            }
            Console.WriteLine(resultString);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            int carryOver = 0;
            ListNode current = result;

            while (l1 != null || l2 != null || carryOver != 0)
            {
                int l1Val = 0, l2Val = 0;
                l1Val = l1 != null ? l1.val : 0;
                l2Val = l2 != null ? l2.val : 0;

                current.next = new ListNode((l1Val + l2Val + carryOver) % 10, null);
                carryOver = (l1Val + l2Val + carryOver) / 10;

                current = current.next;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }

            return result.next;
        }
    }

    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode node = null)
        {
            this.val = val;
            this.next = node;
        }
    }    
}
