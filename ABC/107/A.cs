using System;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split();
        var n = int.Parse(data[0]);
        var i = int.Parse(data[1]);

        Console.WriteLine(n + 1 - i);
    }
}