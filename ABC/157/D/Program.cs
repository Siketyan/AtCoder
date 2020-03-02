using System;
using System.Collections.Generic;
using System.Linq;

namespace D
{
    internal struct Tree
    {
        private readonly int[] _parents;

        public Tree(int n)
        {
            _parents = new int[n];

            for (var i = 0; i < n; ++i)
            {
                _parents[i] = i;
            }
        }

        public int GetRoot(int i)
        {
            if (_parents[i] == i)
            {
                return i;
            }

            return _parents[i] = GetRoot(_parents[i]);
        }

        public void Connect(int a, int b)
        {
            var ra = GetRoot(a);
            var rb = GetRoot(b);

            if (ra != rb)
            {
                _parents[ra] = rb;
            }
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Inputs
             */
            
            var n = Cint();
            var m = Cint();
            var k = Cint();

            var a = new int[m];
            var b = new int[m];

            Loop(m, i =>
            {
                a[i] = Cint() - 1;
                b[i] = Cint() - 1;
            });

            var c = new int[k];
            var d = new int[k];
            
            Loop(k, i =>
            {
                c[i] = Cint() - 1;
                d[i] = Cint() - 1;
            });
            
            /*
             * Solver
             */

            var tree = new Tree(n);

            var friends = new List<int>[n];
            var blocked = new List<int>[n];
            
            Loop(n, i =>
            {
                friends[i] = new List<int>();
                blocked[i] = new List<int>();
            });
            
            Loop(m, i =>
            {
                friends[a[i]].Add(b[i]);
                friends[b[i]].Add(a[i]);
                
                tree.Connect(a[i], b[i]);
            });

            Loop(k, i =>
            {
                blocked[c[i]].Add(d[i]);
                blocked[d[i]].Add(c[i]);
            });
            
            var groups = new Dictionary<int, List<int>>();

            Loop(n, i =>
            {
                var root = tree.GetRoot(i);
                if (!groups.ContainsKey(root))
                {
                    groups.Add(root, new List<int>());
                }

                groups[root].Add(i);
            });

            /*
             * Outputs
             */

            var answer = new int[n];
            
            Loop(n, i =>
            {
                var root = tree.GetRoot(i);
                var group = groups[root];
                var size = group.Count;
                var friendsCount = friends[i].Count(f => tree.GetRoot(f) == root);
                var blockedCount = blocked[i].Count(g => tree.GetRoot(g) == root);

                answer[i] = size - friendsCount - blockedCount - 1;
            });
            
            Cout(
                string.Join(
                    " ",
                    answer.Select(i => i.ToString())
                )
            );
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
