using System;

namespace Console8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            int n = int.Parse(line1);

            string line = null;
            int sumX = 0;
            int sumY = 0;
            bool possibleToChange = false;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                string[] strArr = line.Split();
                int[] arr = Array.ConvertAll<string, int>(strArr, Int32.Parse);
                possibleToChange = possibleToChange || !IsEven(arr[0] + arr[1]);
                sumX += arr[0];
                sumY += arr[1];
            }
            bool xIsEven = IsEven(sumX);
            bool yIsEven = IsEven(sumY);

            if (xIsEven && yIsEven)
            {
                Console.WriteLine(0);
                return;
            }
            if (!xIsEven && !yIsEven)
            {
                if (possibleToChange)
                {
                    Console.WriteLine(1);
                    return;
                }
            }
            Console.WriteLine(-1);
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
