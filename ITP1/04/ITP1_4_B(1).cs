using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        //円周率=Math.PI
        double a = r * r * Math.PI;
        double b = 2 * r * Math.PI;
        Console.WriteLine("{0} {1}", a.ToString("f5"), b.ToString("f5"));
    }
}
