using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split();
        var n = int.Parse(data[0]);
        var x = int.Parse(data[1]);

        var xStr = Console.ReadLine();
        var xAry = xStr.Split().Select(xi => int.Parse(xi)).ToList();
        xAry.Add(x);

        var paddings = new List<int>();
        var previous = -1;
        foreach (var xi in xAry)
        {
            if (previous == -1)
            {
                previous = xi;
                continue;
            }

            paddings.Add(Math.Abs(previous - xi));
        }

        var result = -1;
        foreach (var xi in paddings)
        {
            if (result == -1)
            {
                result = xi;
                continue;
            }

            var res = Gcd(result, xi);
            result = res;
        }

        Console.WriteLine(result);
    }

    public static int Gcd(int a, int b)
    {
        if (a < b)
        {
            return Gcd(b, a);
        }

        while (b != 0)
        {
            var remainder = a % b;

            a = b;
            b = remainder;
        }

        return a;
    }
}