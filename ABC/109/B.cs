using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var known = new List<string>();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var w = Console.ReadLine();

            if (known.Contains(w) || (known.Any() && w.First() != known.Last().Last()))
            {
                Console.WriteLine("No");
                return;
            }

            known.Add(w);
        }

        Console.WriteLine("Yes");
    }
}