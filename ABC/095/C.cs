using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var a = int.Parse(data[0]);
        var b = int.Parse(data[1]);
        var c = int.Parse(data[2]);
        var x = int.Parse(data[3]);
        var y = int.Parse(data[4]);

        var min = x < y ? x : y;
        var max = x < y ? y : x;

        var results = new List<int>();
        
        results.Add(max * c * 2);
        results.Add(min * c * 2 + (x > y ? a : b) * (max - min));
        results.Add((a * x) + (b * y));

        Console.WriteLine(results.Min());
    }
}