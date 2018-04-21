using System;

public class Program
{
    public static void Main(string[] args)
    {
        var s = Console.ReadLine();
        Console.WriteLine(
            s.Contains("a") && s.Contains("b") && s.Contains("c")
                ? "Yes" : "No"
        );
    }
}