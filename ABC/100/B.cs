using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var d = int.Parse(data[0]);
        var n = int.Parse(data[1]);

        if (n == 100)
        {
            n++;
        }

        Console.WriteLine(d > 0 ? n * Math.Pow(100, d) : n);
    }
}