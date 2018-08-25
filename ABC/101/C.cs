using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var data = Console.ReadLine().Split(' ');
        var n = int.Parse(data[0]);
        var k = int.Parse(data[1]);
        var a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        var result = Math.Ceiling((double)n / (k - 1));
        if ((n % (k - 1) != 0 && n % k == 0) || k == 2) result--;

        Console.WriteLine(result);
    }
}