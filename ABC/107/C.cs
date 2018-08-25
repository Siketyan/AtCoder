using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split();
        var n = int.Parse(data[0]);
        var k = int.Parse(data[1]);
        var x = Console.ReadLine().Split().Select(xi => int.Parse(xi)).ToArray();

        var min = int.MaxValue;
        for (var i = 0; i <= x.Length - k; i++)
        {
            var left = x[i];
            var right = x[i + k - 1];

            var lToR = Math.Abs(left) + Math.Abs(right - left);
            var rToL = Math.Abs(right) + Math.Abs(left - right);

            var result = lToR > rToL ? rToL : lToR;
            if (result < min)
            {
                min = result;
            }
        }

        Console.WriteLine(min);
    }
}