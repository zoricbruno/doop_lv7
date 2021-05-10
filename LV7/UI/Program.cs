using FizzBuzz;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            for (int number = start; number <= end; number++)
            {
                FizzBuzzer fizzBuzzer = new FizzBuzzer();
                string message = fizzBuzzer.Convert(number);
                System.Console.WriteLine(message);
            }
        }
    }
}
