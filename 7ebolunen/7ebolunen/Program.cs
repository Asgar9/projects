using System;

namespace _7ebolunen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 23, m = 125,count=0;
            for (int i = n; i < m; i++)
            {
                if (i%7==0)
                {
                    count++;
                    Console.WriteLine( count);
                    Console.ReadLine();
                }
            }
        }
    }
}
