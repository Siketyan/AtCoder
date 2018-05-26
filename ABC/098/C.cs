using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var w = 0;
        var e = 0;

        var bools = new bool[n];
        for (var i = 0; i < n; i++)
        {
            var value = Console.Read() == 'W';
            if (value)
            {
                w++;
            }
            else
            {
                e++;
            }

            bools[i] = value;
        }

        var wi = 0;
        var ei = 0;

        var min = int.MaxValue;
        
        for (var i = 0; i < n; i++)
        {
            var result = 0;
            if (bools[i])
            {
                wi++;
                result = (wi - 1) + (e - ei);
            }
            else
            {
                ei++;
                result = wi + (e - ei);
            }

            if (min > result) min = result;
            if (min == 0) break;
        }

        Console.WriteLine(min);
    }
}