using System;

class Program
{
    static void Main()
    {
        var count = 1;
        var i = 1;

        while (i != 0)
        {
            i = int.Parse(Console.ReadLine());
            if (i != 0) Console.WriteLine("Case {0}: {1}", count, i);
            count ++;
        }
    }
}
