using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<long> inputs = Console.ReadLine().Split(' ').Select(t => long.Parse(t)).ToList();
        Console.WriteLine("{0} {1} {2}", inputs.Min(), inputs.Max(), inputs.Sum());
    }
}
