using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var n = int.Parse(data[0]);
        var d = int.Parse(data[1]);
        var x = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

        var count = 0;
        for (var i = 0; x[i] < x[x.Length - 1] - d; i++)
        {
            var jMax = x[i] + d;
            for (var j = i + 1; j < n - 1 && x[j] <= jMax; j++)
            {
                var kMax = x[j] + d;
                for (var k = j + 1; k < n && x[k] <= kMax; k++)
                {
                    if (x[k] - x[i] > d)
                    {
                        count++;
                    }
                }
            }
        }

        for (var j = 1; j < n - 1; j++)
        {
            var left = 0;
            for (var i = j - 1; i >= 0; i--)
            {
                if (x[j] - x[i] > d)
                {
                    break;
                }

                left++;
            }

            var right = 0;
            for (var k = j + 1; k < n; k++)
            {
                if (x[k] - x[j] > d)
                {
                    break;
                }

                right++;
            }
        }

        Console.WriteLine(count);
    }
}