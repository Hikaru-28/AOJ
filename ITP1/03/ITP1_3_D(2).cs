using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        //int[] x = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();でもよい
        Console.WriteLine(Enumerable.Range(x[0], x[1] - x[0] + 1).Count(q => x[2] % q == 0));
    }
}
