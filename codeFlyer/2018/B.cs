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
        var n = int.Parse(data[2]);
        var x = Console.ReadLine();

        foreach (var ch in x.ToCharArray())
        {
            switch (ch)
            {
                case 'S':
                    if (a > 0)
                    {
                        a--;
                    }
                    break;

                case 'C':
                    if (b > 0)
                    {
                        b--;
                    }
                    break;

                case 'E':
                    if ((a == b && a >= 1) || a > b)
                    {
                        a--;
                    }
                    else if (b > 0)
                    {
                        b--;
                    }
                    break;
            }
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}