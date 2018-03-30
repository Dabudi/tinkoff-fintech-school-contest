using System;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            double N = double.Parse(input[0]);
            double M = double.Parse(input[1]);
            Console.WriteLine((N > 3*M) ? Math.Ceiling((N-3*M)/2) : 0);
        }
    }
}
