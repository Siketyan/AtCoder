using System;
using System.Collections.Generic;
using System.Linq;

namespace B
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var a = new int[3, 3];

            for (var i = 0; i < 3; ++i)
            {
                for (var j = 0; j < 3; ++j)
                {
                    a[i, j] = Cint();
                }
            }

            var n = Cint();
            var b = new int[n];

            for (var i = 0; i < n; ++i)
            {
                b[i] = Cint();
            }

            if (Vertical(a, b) || Horizontal(a, b) || Slash(a, b))
            {
                Cout("Yes");
            }
            else
            {
                Cout("No");
            }
        }

        private static bool Vertical(int[,] a, int[] b)
        {
            for (var i = 0; i < 3; ++i)
            {
                var flag = true;
                
                for (var j = 0; j < 3; ++j)
                {
                    if (!b.Contains(a[i, j]))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Horizontal(int[,] a, int[] b)
        {
            for (var i = 0; i < 3; ++i)
            {
                var flag = true;

                for (var j = 0; j < 3; ++j)
                {
                    if (!b.Contains(a[j, i]))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Slash(int[,] a, int[] b)
        {
            return (b.Contains(a[0, 0]) && b.Contains(a[1, 1]) && b.Contains(a[2, 2])) ||
                   (b.Contains(a[2, 0]) && b.Contains(a[1, 1]) && b.Contains(a[0, 2]));
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
