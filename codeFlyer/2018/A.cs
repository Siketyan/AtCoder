using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        for (var i = a; i >= 1; i--)
        {
            if (i % b == 0)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}