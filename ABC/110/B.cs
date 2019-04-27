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
        var m = int.Parse(data[1]);
        var x = int.Parse(data[2]);
        var y = int.Parse(data[3]);

        var xn = Console.ReadLine().Split().Select(xi => int.Parse(xi));
        var ym = Console.ReadLine().Split().Select(yi => int.Parse(yi));

        var flag = false;
        for (var z = -100; z <= 100; z++)
        {
            if (x < z && z <= y &&
                !xn.Any(xi => xi >= z) &&
                !ym.Any(yi => yi < z))
            {
                flag = true;
            }
        }

        Console.WriteLine(flag ? "No War" : "War");
    }
}