using System;
using System.Text;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string seq = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append("^");
            bool empty = false;
            if (seq.Length == 0) empty = true;
            for(int i = 0; i < seq.Length; ++i)
            {
                sb.Append("#").Append(seq[i]);
            }
            sb.Append("#$");
            seq = sb.ToString();
            var palindromes = new int[seq.Length];
            int c = 0, r = 0;
            int count = 0;
            for (int i = 1; i < seq.Length - 1; i++)
            {
                int j = c - (i - c); 
                palindromes[i] = (r > i) ? Math.Min(r - i, palindromes[j]) : 0;
                while (seq[i + 1 + palindromes[i]] == seq[i - 1 - palindromes[i]])
                {
                    palindromes[i]++;
                }
                if (i + palindromes[i] > r)
                {
                    c = i;
                    r = i + palindromes[i];
                }
            }
            for(int i = 1; i < seq.Length - 1; ++i)
            {
                count += palindromes[i] / 2 + palindromes[i] % 2;
            }
            Console.WriteLine((empty) ? 0 : count);
        }
    }
}
