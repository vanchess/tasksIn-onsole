using System;

namespace Console3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] nmkp = str.Split();
            int n = Int32.Parse(nmkp[0]);
            int min = Int32.Parse(nmkp[1]);
            int max = Int32.Parse(nmkp[2]);
            int minDif = Int32.Parse(nmkp[3]);

            str = Console.ReadLine();
            string[] cStr = str.Split();
            int[] c = Array.ConvertAll<string, int>(cStr, Int32.Parse);
            Array.Sort(c);

            int result = 0;
            for(int i = 0; i < n; i++)
            {
                if (c[i] > max)
                {
                    break;
                }
                for(int k = n-1; k > i; k--)
                {
                    int currentSum = c[i] + c[k];
                    if(currentSum > max)
                    {
                        continue;
                    }
                    if((c[k] - c[i]) < minDif)
                    {
                        break;
                    }
                    if(currentSum >= min)
                    {
                        result++;
                    }

                    result += F(i + 1, k - 1, min - currentSum, max - currentSum, c);
                }      
            }
            Console.WriteLine(result);
        }

        private static int F(int start, int end, int min, int max, in int[] arr)
        {
            int result = 0;
            for(int l = end; l >= start; l--)
            {
                if(arr[l] > max)
                {
                    continue;
                }
                if(arr[l] < min)
                {
                    break;
                }
                result++;
                result += F(start, l-1, min-arr[l], max-arr[l], arr);
            }
            return result;
        }
    }
}
