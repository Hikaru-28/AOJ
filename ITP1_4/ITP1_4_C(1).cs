using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[2]);
            string s = inputs[1];

            if (s == "+") Console.WriteLine(a + b);
            else if (s == "-") Console.WriteLine(a - b);
            else if (s == "*") Console.WriteLine(a * b);
            else if (s == "/") Console.WriteLine(a / b);
            else break;
        }
    }
}
