using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var n = int.Parse(data[0]);
        var x = int.Parse(data[1]);
        var m = new int[n];

        for (var i = 0; i < n; i++)
        {
            m[i] = int.Parse(Console.ReadLine());
        }

        var count = 0;
        foreach (var i in m)
        {
            count++;
            x -= i;
        }

        var min = m.Min();
        while (x >= min)
        {
            count++;
            x -= min;
        }

        Console.WriteLine(count);
    }
}