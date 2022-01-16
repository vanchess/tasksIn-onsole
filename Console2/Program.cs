using System;

namespace Console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] s = str.Split('+');
            Array.Sort(s);
            str = String.Join("+", s);
            Console.WriteLine(str);
        }
    }
}
