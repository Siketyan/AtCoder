using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split();
        var h = int.Parse(data[0]);
        var w = int.Parse(data[1]);

        var a = new int[h, w];
        for (var y = 0; y < h; y++)
        {
            var l = Console.ReadLine();
            var strs = l.Split();
            for (var x = 0; x < w; x++)
            {
                a[y, x] = int.Parse(strs[x]);
            }
        }

        var count = 0;
        var buffer = new List<string>();
        for (var y = 0; y < h; y++)
        {
            for (var x = 0; x < w; x++)
            {
                if (a[y, x] % 2 != 0)
                {
                    if (x == w - 1 && y == h - 1)
                    {
                        continue;
                    }

                    if (x == w - 1)
                    {
                        a[y, x]--;
                        a[y + 1, x]++;

                        buffer.Add($"{y + 1} {x + 1} {y + 2} {x + 1}");
                    }
                    else
                    {
                        a[y, x]--;
                        a[y, x + 1]++;

                        buffer.Add($"{y + 1} {x + 1} {y + 1} {x + 2}");
                    }

                    count++;
                }
            }
        }

        Console.WriteLine(count);
        foreach (var l in buffer)
        {
            Console.WriteLine(l);
        }
    }
}