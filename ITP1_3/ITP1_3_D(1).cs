using System;

class Program
{
    static void Main()
    {
        string[] i = Console.ReadLine().Split(' ');
        int a = int.Parse(i[0]);
        int b = int.Parse(i[1]);
        int c = int.Parse(i[2]);
        var count = 0;

        for (int x = a; x <= b; x ++)
        {
          if (c % x == 0) count ++;
        }
        Console.WriteLine(count);
    }
}
