using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var q = int.Parse(Console.ReadLine());

        for (var i = 1; i <= q; i++)
        {
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
            var b = int.Parse(data[1]);

            var score = a * b;
            var max = a > b ? a : b;

            var kMax = 0;
            var count = 0;
            for (var j = 1; j < score; j++)
            {
                if (j == a) continue;

                for (var k = 1; j * k < score; k++)
                {
                    if (k == b) continue;
                    if (kMax >= k) continue;
                    else kMax = k;

                    Console.WriteLine($"{j}, {k}");

                    count++;
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}