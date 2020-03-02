using System;
using System.Collections.Generic;
using System.Linq;

namespace F
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            
        }

        #region Input and Output

        private static readonly List<string> Buffer = new List<string>();

        private static string Cin()
        {
            ReadBuffer();

            var str = Buffer.First();
            Buffer.RemoveAt(0);

            return str;
        }

        private static IEnumerable<string> CinA() => Console.ReadLine()?.Split();
        private static int Cint() => int.Parse(Cin());
        private static int[] CintA() => CinA().Select(int.Parse).ToArray();
        private static void Cout(object obj) => Console.WriteLine(obj);

        private static void ReadBuffer()
        {
            if (Buffer.Any()) return;

            var line = Console.ReadLine();
            if (line != null && line.Contains(' '))
            {
                Buffer.AddRange(line.Split());
            }
            else
            {
                Buffer.Add(line);
            }
        }

        #endregion

        #region Loops

        private static void Loop(int count, Action<int> action) => Loop(0, count, action);

        private static void Loop(int init, int count, Action<int> action, int step = 1)
        {
            for (var i = init; i < count + init; i += step)
            {
                action(i);
            }
        }

        #endregion
    }
}
