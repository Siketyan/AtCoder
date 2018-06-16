using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var a = int.Parse(data[0]);
        var b = int.Parse(data[1]);

        var index = b - a;
        var length = 0;
        for (var i = 1; i <= index; i++)
        {
            length += i;
        }

        Console.WriteLine(length - b);
    }
}