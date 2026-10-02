using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_4
{
    public interface ISummableOfSomePair<Tself> : IPair where Tself : IPair
    {
        (int, int) SumOfPair(Tself pair1, Tself pair2);
        (int, int) SumOfPair(Tself pair, Tself pair2, Tself pair3);
    }
}
