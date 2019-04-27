using System;
using System.Collections.Generic;
using System.Linq;

namespace B
{
    internal class Program
    {
        public static void Main()
        {
            var n = Cint();
            var v = CintA();
            var c = CintA();

            var x = new int[n];
            Loop(n, i =>
            {
                x[i] = i;
            });

            x = x.OrderByDescending(i => v[i] - c[i]).ToArray();

            var sum = 0;
            var max = 0;
            foreach (var i in x)
            {
                sum += v[i] - c[i];
                if (sum > max)
                {
                    max = sum;
                }
            }

            Cout(max);
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

        private static IEnumerable<string> CinA() => Console.ReadLine().Split();
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
