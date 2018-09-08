using System;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split();
        var a = int.Parse(data[0]);
        var b = int.Parse(data[1]);

        for (var c = 1; c <= 3; c++)
        {
            if ((a * b * c) % 2 != 0)
            {
                Console.WriteLine("Yes");
                return;
            }
        }

        Console.WriteLine("No");
    }
}