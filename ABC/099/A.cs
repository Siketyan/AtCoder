using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine(n < 1000 ? "ABC" : "ABD");
    }
}