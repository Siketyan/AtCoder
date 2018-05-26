using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.ReadLine(); // Ignore

        var s = Console.ReadLine();

        var max = 0;
        for (var i = 1; i < s.Length - 1; i++)
        {
            var x = s.Substring(0, i);
            var y = s.Substring(i);

            var xChars = x.ToCharArray();
            var yChars = y.ToCharArray();

            var read = new List<char>();
            var result = 0;
            
            foreach (var ch in xChars)
            {
                if (read.Contains(ch)) continue;
                if (yChars.Contains(ch)) result++;

                read.Add(ch);
            }

            if (max < result) max = result;
        }

        Console.WriteLine(max);
    }
}