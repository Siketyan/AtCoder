using System;
using System.Collections.Generic;
using System.Linq;

namespace C
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Cint();
            var m = Cint();

            var s = new int[m];
            var c = new int[m];

            Loop(m, i =>
            {
                s[i] = Cint();
                c[i] = Cint();
            });
            
            var num = new string('0', n).ToCharArray();
            var written = new List<Tuple<int, int>>();
            
            Loop(m, i =>
            {
                if (written.Any(w => w.Item1 == s[i] && w.Item2 != c[i]) || s[i] == 1 && c[i] == 0 && n > 1)
                {
                    Cout(-1);
                    Environment.Exit(0);
                }
                
                num[s[i] - 1] = c[i].ToString().First();
                written.Add(new Tuple<int, int>(s[i], c[i]));
            });
            
            if (num[0] == '0' && n > 1)
            {
                num[0] = '1';
            }
            
            Cout(int.Parse(new string(num)));
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
