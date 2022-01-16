using System;

namespace Console7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            int n = int.Parse(line1);
            
            if(n == 1 || n == 2)
            {
                Console.WriteLine("1");
                Console.WriteLine("1");
                return;
            }
            if (n == 3)
            {
                Console.WriteLine("1");
                Console.WriteLine("1 3");
                return;
            }
            Console.WriteLine(n);
            string[] arr = new String[n];
            int pos = 0;
            for (int i = 2; i <= arr.Length; i+=2)
            {
                arr[pos++] = i.ToString();
            }
            for (int i = 1; i <= arr.Length; i += 2)
            {
                arr[pos++] = i.ToString();
            }
            Console.WriteLine(String.Join(' ',arr));
        }
    }
}
