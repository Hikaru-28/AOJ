using System;

namespace ITP1_3_C
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] i = Console.ReadLine().Split(' ');
                int x = int.Parse(i[0]);
                int y = int.Parse(i[1]);

                if (x == 0 && y == 0) break;
                Console.WriteLine("{0} {1}", Math.Min(x, y), Math.Max(x, y));
            }
        }
    }
}
