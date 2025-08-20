namespace InterviewProblems.DataStructures
{
    public class ListProblems
    {
        public ListProblems()
        {
            List<int> items = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                items.Add(i);
            }

            items.Remove(2);
            items.RemoveAt(3);
            items.RemoveRange(0, 2);   
            items.Add(6);
            items.Exists(x => x == 3);
            items.Except(new List<int> { 1, 2 });
            items.ExceptBy(new List<int> { 1, 2 }, null);
        }
    }
}