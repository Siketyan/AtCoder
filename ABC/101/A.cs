using System;

public class Program
{
    public static void Main(string[] args)
    {
        var s = Console.ReadLine();
        var result = 0;

        foreach (var c in s.ToCharArray())
        {
            if (c == '+')
            {
                result++;
            }
            else if (c == '-')
            {
                result--;
            }
        }

        Console.WriteLine(result);
    }
}