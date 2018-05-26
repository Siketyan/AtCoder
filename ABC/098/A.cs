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

        var result = new List<int>();

        result.Add(a + b);
        result.Add(a - b);
        result.Add(a * b);

        Console.WriteLine(result.Max());
    }
}