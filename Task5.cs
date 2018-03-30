using System;
using System.Collections.Generic;


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            var weights = new int[N];
            for(int i = 0; i < N; ++i)
            {
                weights[i] = int.Parse(input[i]);
            }
            int M = int.Parse(Console.ReadLine());
            var graph = new List<int>[N];
            for(int i = 0; i < N; ++i)
            {
                graph[i] = new List<int>();
            }
            for(int i = 0; i < M; ++i)
            {
                input = Console.ReadLine().Split(' ');
                graph[int.Parse(input[0]) - 1].Add(int.Parse(input[1]) - 1);
                graph[int.Parse(input[1]) - 1].Add(int.Parse(input[0]) - 1);
            }
            var lens = new int[N];
            var used = new bool[N];
            lens[0] = weights[0];
            for(int i = 1; i < N; ++i)
            {
                lens[i] = int.MaxValue;
            }
            int min = int.MaxValue;
            int minIndex = -1;
            for(int i = 0; i < N; ++i)
            {
                for(int j = 0; j < N; ++j)
                {
                    if(lens[j] < min && !used[j])
                    {
                        min = lens[j];
                        minIndex = j;
                    }
                }

                for(int j = 0; j < graph[minIndex].Count; j++)
                {
                    if(weights[graph[minIndex][j]] + lens[minIndex] < lens[graph[minIndex][j]])
                    {
                        lens[graph[minIndex][j]] = weights[graph[minIndex][j]] + lens[minIndex];
                    }
                }
                min = int.MaxValue;
                used[minIndex] = true;
            }
            Console.WriteLine((lens[N-1] != int.MaxValue) ? (lens[N-1] - weights[N-1]) : -1);
        }
    }
}
