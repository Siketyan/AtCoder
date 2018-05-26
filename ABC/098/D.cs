using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        var count = 0;
        for (var l = 0; l < n; l++)
        {
            var left = a[l];
            var right = a[l];

            for (var r = l; r < n; r++)
            {
                if (l == r) continue;

                left ^= a[r];
                right += a[r];

                if (left == right)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count + n);
    }
}