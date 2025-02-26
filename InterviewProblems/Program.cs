// See https://aka.ms/new-console-template for more information
namespace InterviewProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var integerContainer = new IntegerContainer.IntegerContainer();
            
            integerContainer.Add(-20);
            integerContainer.Add(-10);
            integerContainer.Add(10);
            integerContainer.Add(20);
            integerContainer.Add(0);
            integerContainer.GetMedian();
            integerContainer.Add(-30);
            integerContainer.GetMedian();
            integerContainer.Add(30);
            integerContainer.GetMedian();
            integerContainer.Add(40);
            integerContainer.Add(50);
            integerContainer.GetMedian();
        }
    }
}