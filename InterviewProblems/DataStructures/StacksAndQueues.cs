namespace InterviewProblems.DataStructures
{
    public class TreeNode1
    {
        public int Value { get; set; }
        public TreeNode1 Left { get; set; }
        public TreeNode1 Right { get; set; }
    }

    public class StacksAndQueues
    {
        public StacksAndQueues()
        {
            Console.WriteLine("Stack");
            var stack = new Stack<TreeNode1>();
            stack.Push(new TreeNode1() {Value = 1});
            stack.Push(new TreeNode1() {Value = 2});
            stack.Push(new TreeNode1() {Value = 3});
            stack.Push(new TreeNode1() {Value = 4});
            stack.Push(new TreeNode1() {Value = 5});

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().Value);
            }

            Console.WriteLine("Queue");
            var queue = new Queue<TreeNode1>();
            queue.Enqueue(new TreeNode1() {Value = 1});
            queue.Enqueue(new TreeNode1() {Value = 2});
            queue.Enqueue(new TreeNode1() {Value = 3});
            queue.Enqueue(new TreeNode1() {Value = 4});
            queue.Enqueue(new TreeNode1() {Value = 5});
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue().Value);
            }
        }
    }
}