using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticProgression
{
    class ArithmeticProgression:IIndexibleSeries
    {
        double IIndexable.this[int index] => throw new NotImplementedException();
        int nachalo = 4;
        int value = 4;
        void ISeries.Reset()
        {
            value = nachalo;
        }
        bool ISeries.MoveNext()
        {
            return true;
        }

        double ISeries.GetCurrent()
        {
            value += value;
            return value;
        }


    }
}
