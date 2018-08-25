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
        var a = new bool[w, h];

        var skipRows = new List<int>();
        var skipColumns = new List<int>();

        for (var i = 0; i < h; i++)
        {
            var chars = Console.ReadLine().ToCharArray();
            if (!chars.Any(x => x == '#'))
            {
                skipRows.Add(i);
            }

            for (var j = 0; j < w; j++)
            {
                var ch = chars[j];
                a[j, i] = ch == '#';
            }
        }

        for (var i = 0; i < w; i++)
        {
            var allWhite = true;

            for (var j = 0; j < h; j++)
            {
                if (a[i, j])
                {
                    allWhite = false;
                }
            }

            if (allWhite)
            {
                skipColumns.Add(i);
            }
        }

        for (var i = 0; i < h; i++)
        {
            if (skipRows.Contains(i))
            {
                continue;
            }

            for (var j = 0; j < w; j++)
            {
                if (skipColumns.Contains(j))
                {
                    continue;
                }

                Console.Write(a[j, i] ? '#' : '.');
            }

            Console.WriteLine();
        }
    }
}