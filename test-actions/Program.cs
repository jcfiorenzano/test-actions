using System;

namespace test_actions
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Calculator();
            Console.WriteLine(test.sum(1, 2));
        }
    }
}
