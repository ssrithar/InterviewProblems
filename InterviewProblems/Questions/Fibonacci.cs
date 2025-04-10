namespace InterviewProblems.Questions
{
    public class Fibonacci
    {
        public Fibonacci()
        {
            int fib = 10;

            Console.WriteLine("Fibonacci Recursive: Starts");
            Console.WriteLine(FibonacciRecursive(fib));
            Console.WriteLine("Fibonacci Recursive: Ends");

            Console.WriteLine("Fibonacci Iterative: Starts");
            Console.WriteLine(FibonacciIterative(fib));
            Console.WriteLine("Fibonacci Iterative: Ends");
        }
        public static int FibonacciRecursive(int n)
        {
            Console.WriteLine($"Calculating Fibonacci({n})");
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public static int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}