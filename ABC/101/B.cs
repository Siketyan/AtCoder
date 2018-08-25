using System;

public class Program
{
    public static void Main(string[] args)
    {
        var str = Console.ReadLine();
        var n = int.Parse(str);

        var s = 0;
        foreach (var c in str.ToCharArray())
        {
            s += int.Parse(c.ToString());
        }

        Console.WriteLine(n % s == 0 ? "Yes" : "No");
    }
}