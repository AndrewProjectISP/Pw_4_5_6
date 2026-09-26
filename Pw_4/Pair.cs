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
        public Pair(int x, int y)
        {
            first = x; second = y;
        }
        public int first
        {
            get;
            set;
        }
        public int second
        {
            get;
            set;
        }
        internal int SumOfFirstSecond()
        {
            return first+second;
        }
        internal static (int, int) SumOfPair(Pair pair1,Pair pair2)
        {
            return (pair1.first + pair2.first, pair1.second + pair2.second);
        }
        internal static (int, int) SumOfPair(Pair pair,Pair pair2, Pair pair3)
        {
            return (pair.first + pair2.first + pair3.first, pair.second + pair2.second + pair3.second);
        }

        internal (int, int) IncrementPostFix(Pair pair)
        {
            return (pair.first++, pair.second++);
        }
        internal (int, int) IncrementPreFix(Pair pair)
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
