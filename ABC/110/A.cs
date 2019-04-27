using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split();
        var a = int.Parse(data[0]);
        var b = int.Parse(data[1]);
        var c = int.Parse(data[2]);

        var numbers = new List<int>();
        numbers.Add(a);
        numbers.Add(b);
        numbers.Add(c);

        var sorted = numbers.OrderByDescending(x => x).ToArray();
        Console.WriteLine((sorted[0] * 10) + sorted[1] + sorted[2]);
    }
}