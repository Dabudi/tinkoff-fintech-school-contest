using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lower = new char[26];
            var upper = new char[26];
            var cipher = Console.ReadLine().ToCharArray();
            int len = 0;
            int max = 0;
            int i = 0;
            for(i = 0; i < cipher.Length; ++i)
            {
                if (Char.IsLetter(cipher[i]))
                {
                    ++len;
                    if (len > max) max = len;
                }
                else
                {
                    len = 0;
                }
            }
            i = 0;
            for(char c = 'a'; c <= 'z'; ++c)
            {
                lower[i] = c;
                ++i;
            }
            i = 0;
            for(char c = 'A'; c <= 'Z'; ++c)
            {
                upper[i] = c;
                ++i;
            }
            for(i = 0; i < cipher.Length; ++i)
            {
                if (Char.IsLower(cipher[i]))
                {
                    cipher[i] = lower[(Array.IndexOf(lower, cipher[i]) + max) % 26];
                }
                else if (Char.IsUpper(cipher[i]))
                {
                    cipher[i] = upper[(Array.IndexOf(upper, cipher[i]) + max) % 26];
                }
                Console.Write(cipher[i]);
            }
        }
    }
}
