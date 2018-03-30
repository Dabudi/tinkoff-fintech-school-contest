using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            ulong prod = 1;

            prod = (ulong)Math.Pow(Factorial(N)/(Factorial(N-K) * Factorial(K)), 2);
            Console.WriteLine(prod*Factorial(K));
        }

        static ulong Factorial(int N)
        {
            if (N == 0) ;
            ulong prod = 1;
            for(ushort i = 2; i <= N; ++i)
            {
                prod *= i;
            }
            return prod;
        }
    }
}
