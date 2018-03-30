using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int count = 0;
            int M = int.Parse(input[1]);
            var copy = new int[M + 1][];
            var field = new int[N+1][];
            for(int i = 0; i < N; ++i)
            {
                field[i] = new int[M+1];
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; ++j)
                {
                    field[i][j] = int.Parse(input[j]);
                }
                field[i][M] = 1;
            }
            field[N] = new int[M + 1];
            for(int i = 0; i <= M; ++i)
            {
                copy[i] = new int[N+1];
                field[N][i] = 1;
                copy[i][N] = 1;
            }
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    copy[j][i] = field[i][j];
                }
            }
            for (int i = 0; i < N; ++i)
            {
                copy[M][i] = 1;
            }
            int x = 0, y = 0, xStart = 0, yStart = 0;
            bool expanding = true;
            while(x < M && y < N)
            {
                xStart = x;
                yStart = y;
                if(field[y][x] == 0)
                {
                    while(field[y][x] == 0)
                    {
                        field[y][x] = 1;
                        ++x;
                    }
                    while (expanding)
                    {
                        ++y;
                        for(int i = xStart; i < x; ++i)
                        {
                            if(field[y][i] == 1)
                            {
                                expanding = false;
                                break;
                            }
                        }
                    }
                    ++count;
                }
                if(x < M - 1)
                {
                    ++x;
                    y = yStart;
                }
                else
                {
                    x = 0;
                    y = yStart + 1;
                }
            }
            int count1 = 0;
            x = 0; y = 0; xStart = 0; yStart = 0;
            expanding = true;
            while (y < M && x < N)
            {
                xStart = x;
                yStart = y;
                if (copy[y][x] == 0)
                {
                    while (copy[y][x] == 0)
                    {
                        copy[y][x] = 1;
                        ++x;
                    }
                    while (expanding)
                    {
                        ++y;
                        for (int i = xStart; i < x; ++i)
                        {
                            if (copy[y][i] == 1)
                            {
                                expanding = false;
                                break;
                            }
                        }
                    }
                    ++count1;
                }
                if (x < N - 1)
                {
                    ++x;
                    y = yStart;
                }
                else
                {
                    x = 0;
                    y = yStart + 1;
                }
            }
            Console.WriteLine(Math.Min(count, count1));
            Console.Read();
        }
    }
}
