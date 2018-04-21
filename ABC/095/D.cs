using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public class Sushi
    {
        public long X { get; }
        public int V { get; }
        public long Moves { get; set; }
        public long Score { get; set; }

        public Sushi(long x, int v)
        {
            X = x;
            V = v;
            Moves = Score = 0;
        }
    }

    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var n = int.Parse(data[0]);
        var c = long.Parse(data[1]);
        var x = new List<Sushi>();

        for (var i = 0; i < n; i++)
        {
            var l = Console.ReadLine();
            var d = l.Split(' ');
            x.Add(new Sushi(long.Parse(d[0]), int.Parse(d[1])));
        }

        var moves = 0L;
        var cal = 0;

        var position = 0L;
        while (true)
        {
            if (!x.Any()) break;

            var center = (position + c / 2);
            if (center > c) center -= c;

            // Console.WriteLine($"{position} to... (Center: {center})");
            foreach (var s in x)
            {

                if (s.X < center)
                {
                    s.Moves = s.X - position;
                    s.Score = s.V - s.Moves;
                    // Console.WriteLine($"?{s.X} {s.Moves} moves, {s.V} cal => {s.Score}");
                }
                else
                {
                    s.Moves = (c - s.X) + position;
                    s.Score = s.V - s.Moves;
                    // Console.WriteLine($"?{s.X} {s.Moves} moves, {s.V} cal => {s.Score}");
                }
            }

            var max = x.Max(s => s.Score);
            if (max < 0)
            {
                break;
            }

            var sushi = x.Where(s => s.Score > 0).OrderBy(s => s.Moves).First();
            if (sushi.X < center)
            {
                moves += sushi.Moves;
                cal += sushi.V;
                position = sushi.X;
            }
            else
            {
                moves += sushi.Moves;
                cal += sushi.V;
                position = sushi.X;

            }
            x.Remove(sushi);
            // Console.WriteLine($"{moves} moves, {cal} cals\n");
        }

        Console.WriteLine(cal - moves);
    }
}