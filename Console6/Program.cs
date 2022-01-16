using System;

namespace Console6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();

            int p = int.Parse(line1);
            string[] aStr = line2.Split();
            int[] a = Array.ConvertAll<string, int>(aStr, Int32.Parse);
            Array.Sort(a);

            int k = int.Parse(line3);
            string[] bStr = line4.Split();
            int[] b = Array.ConvertAll<string, int>(bStr, Int32.Parse);
            Array.Sort(b);

            int i = 0;
            int j = 0;
            int result = 0;
            while (i < p && j < k)
            {
                if (Math.Abs(a[i] - b[j]) <= 1)
                {
                    result++;
                    i++;
                    j++;
                    continue;
                }
                if(a[i] > b[j])
                {
                    j++;
                } else
                {
                    i++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
