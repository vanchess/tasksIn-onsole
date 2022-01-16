using System;

namespace Console4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int result = 0;
            int pos = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if(str[pos] == '4')
                {
                    // 1 * 2 ^ i
                    result += 1 * (1 << i);
                } else
                {
                    // 2 * 2 ^ i
                    result += 2 << i;
                }
                pos++;
            }

            Console.WriteLine(result);
        }
    }
}
