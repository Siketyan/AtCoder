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
        var k = int.Parse(data[2]);
        
        var j = 0;
        for (var i = a; i <= b; i++)
        {
            if (j < k || j > b - a - k)
            {
                Console.WriteLine(i);
            }

            j++;
        }
    }
}