namespace InterviewProblems.DataStructures
{
    public class LinkedLists
    {
        LinkedList<int> list;

        public LinkedLists()
        {
            list = new LinkedList<int>();
            PrintList();

            list.AddLast(8);
            PrintList();
        }

        public void PrintList()
        {
            Console.WriteLine($"List Length: {list.Count}, First: {list.First?.Value}, Last: {list.Last?.Value}");
        }
    }
}