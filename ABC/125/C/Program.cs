using System;
using System.Collections.Generic;
using System.Linq;

namespace C
{
    internal class Program
    {
        public static void Main()
        {
            var n = Cint();
            var a = CintA().OrderBy(ai => ai).ToArray();

            var gcds = new List<int>(3)
            {
                Gcd(a[0], a[n - 1]),
                Gcd(a[0], a[n - 2]),
                Gcd(a[1], a[n - 1])
            };

            var gcd = gcds.Max();

            while (gcds.Count > 1)
            {
                gcds.Clear();

                foreach (var ai in a)
                {
                    if (ai % gcd != 0)
                    {
                        gcds.Add(Gcd(ai, gcd));
                    }
                }

                if (gcds.Count > 1)
                {
                    gcd = gcds.OrderBy(gi => gi).ElementAt(1);
                }
            }

            Cout(gcd);
        }

        public static int Gcd(int a, int b)
        {
            return a > b ? GcdRecursive(a, b) : GcdRecursive(b, a);
        }

        private static int GcdRecursive(int a, int b)
        {
            return b == 0 ? a : GcdRecursive(b, a % b);
        }

        #region Input and Output

        private static readonly List<string> _buffer = new List<string>();

        private static string Cin()
        {
            ReadBuffer();

            var str = _buffer.First();
            _buffer.RemoveAt(0);

            return str;
        }

        private static IEnumerable<string> CinA() => Console.ReadLine()?.Split();
        private static int Cint() => int.Parse(Cin());
        private static int[] CintA() => CinA().Select(int.Parse).ToArray();
        private static void Cout(object obj) => Console.WriteLine(obj);

        private static void ReadBuffer()
        {
            if (_buffer.Any()) return;

            var line = Console.ReadLine();
            if (line.Contains(' '))
            {
                _buffer.AddRange(line.Split());
            }
            else
            {
                _buffer.Add(line);
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
