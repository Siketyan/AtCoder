using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.ReadLine(); // Ignore

        var line = Console.ReadLine();
        var a = line.Split(' ').Select(x => int.Parse(x)).ToArray();

        var count = 0;
        for (var i = 0; i < a.Length; i++)
        {
            while (a[i] % 2 == 0)
            {
                a[i] /= 2;
                count++;
            }
        }

        Console.WriteLine(count);
    }
}