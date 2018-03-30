using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            var field = new int[N][];
            var copy = new int[N][];
            for(int i = 0; i < N; ++i)
            {
                field[i] = new int[M];
                copy[i] = new int[M];
                input = Console.ReadLine().Split(' ');
                for(int j = 0; j < M; ++j)
                {
                    field[i][j] = int.Parse(input[j]);
                    copy[i][j] = int.Parse(input[j]);
                }
            }

        }
    }
}
