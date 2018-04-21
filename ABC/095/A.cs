using System;

public class Program
{
    public static void Main(string[] args)
    {
        var s = Console.ReadLine();
        var chars = s.ToCharArray();
        var ajitama = chars[0] == 'o';
        var chashu = chars[1] == 'o';
        var negi = chars[2] == 'o';

        var price = 700;
        if (ajitama) price += 100;
        if (chashu) price += 100;
        if (negi) price += 100;

        Console.WriteLine(price);
    }
}