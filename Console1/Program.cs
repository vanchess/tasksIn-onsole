using System;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string m = Console.ReadLine();
            /*
            string str = Console.ReadLine();
            string[] s = str.Split();
            string n = s[0];
            string m = s[1];
            */

            char[] nCharArray = n.ToCharArray();
            Array.Sort(nCharArray);
            int i = 0;

            if (nCharArray[i] == '0')
            {
                
                while (i < (nCharArray.Length - 1) && nCharArray[i] == '0')
                {
                    i++;
                }
                nCharArray[0] = nCharArray[i];
                nCharArray[i] = '0';
            }
            n = new String(nCharArray);

            if (n == m)
            {
                Console.WriteLine("OK");
            } else
            {
                Console.WriteLine("ERROR");
            }
            
        }
    }
}
