using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Japanese Olympiad in Informatics 2019
/// </summary>
namespace JOI2019
{
    /// <summary>
    /// Problem E (5 of 6)
    /// </summary>
    public static class E
    {
        /// <summary>
        /// Entrypoint
        /// </summary>
        public static void Main()
        {

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

        private static string[] CinA() => Console.ReadLine().Split();
        private static int Cint() => int.Parse(Cin());
        private static int[] CintA() => CinA().Select(x => int.Parse(x)).ToArray();
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
        #region LCM and GCD

        private static int Lcm(int a, int b) => a * b / Gcd(a, b);
        private static int Gcd(int a, int b)
        {
            int gcd(int x, int y) => y == 0 ? x : gcd(y, x % y);
            return a > b ? gcd(a, b) : gcd(b, a);
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
