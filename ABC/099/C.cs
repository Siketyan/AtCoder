using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var count = 0;
        if (n >= 6)
        {
            while (true)
            {
                var log9 = Math.Log(n, 9);
                var log6 = Math.Log(n, 6);

                var pow9 = (int)Math.Pow(9.0d, Math.Truncate(log9));
                var pow6 = (int)Math.Pow(6.0d, Math.Truncate(log6));

                if (pow9 > pow6 && n >= 9)
                {
                    n -= pow9;
                    count++;
                    continue;
                }
                else if (n >= 6)
                {
                    n -= pow6;
                    count++;
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        Console.WriteLine(count + n);
    }
}