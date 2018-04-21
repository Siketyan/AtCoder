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
        var c = int.Parse(data[2]);

        var count = 0;
        while (a != b || a != c)
        {
            count++;

            if (a == b)
            {
                if (a < c) // 0 0 1
                {
                    a++;
                    b++;
                }
                else // 1 1 0
                {
                    c += 2;
                }
            }
            else if (b == c)
            {
                if (a > b) // 1 0 0
                {
                    b++;
                    c++;
                }
                else // 0 1 1
                {
                    a += 2;
                }
            }
            else if (a == c)
            {
                if (a < b) // 0 1 0
                {
                    a++;
                    c++;
                }
                else // 1 0 1
                {
                    b += 2;
                }
            }
            else
            {
                if (a > b && a > c) // A is max
                {
                    b++;
                    c++;
                }
                else if (b > a && b > c) // B is max
                {
                    a++;
                    c++;
                }
                else if (c > a && c > b) // C is max
                {
                    a++;
                    b++;
                }
            }
        }

        Console.WriteLine(count);
    }
}