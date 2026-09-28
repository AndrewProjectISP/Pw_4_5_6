using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Pw_4
{
    internal class Pair
    {
        public Pair(int x, int y, int number)
        {
            first = x; second = y; Number = number;
        }
        public int first { get; set; }
        public int second { get; set; }
        private int _number;
        public int Number { get { return _number; } private set { if (value > 0) _number = value; } }
        public override string ToString()
        {
            return $"Pair №{Number}";
        }
        public int SumOfFirstSecond()
        {
            return first+second;
        }
        public static (int, int) SumOfPair(Pair pair1,Pair pair2)
        {
            return (pair1.first + pair2.first, pair1.second + pair2.second);
        }
        public static (int, int) SumOfPair(Pair pair,Pair pair2, Pair pair3)
        {
            return (pair.first + pair2.first + pair3.first, pair.second + pair2.second + pair3.second);
        }

        public (int, int) IncrementPostFix(Pair pair)
        {
            return (pair.first++, pair.second++);
        }
        public (int, int) IncrementPreFix(Pair pair)
        {
            return (++pair.first, ++pair.second);
        }
        public static (int, int) operator +(Pair pair1, Pair pair2)
        {
            return (pair1.first + pair2.first, pair1.second + pair2.second);
        }
        public static (int, int) operator -(Pair pair, Pair pair2)
        {
            return (pair.first - pair2.first, pair.second - pair2.second);
        }
        public static Pair operator ++(Pair pair)
        {
            pair.first = pair.first + 1;
            pair.second = pair.second + 1;
            return pair;
        }
        public static Pair operator --(Pair pair)
        {
            pair.first = pair.first - 1;
            pair.second = pair.second - 1;
            return pair;
        }
    }
}
