using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticProgression
{
    class GeometricProgression:IIndexibleSeries
    {
        double IIndexable.this[int index] => throw new NotImplementedException();

        int nachalo = 2;
        int value = 2;
        int value2 = 4;

        bool ISeries.MoveNext()
        {
            return true;
        }

        void ISeries.Reset()
        {
            value = nachalo;
        }
        double ISeries.GetCurrent()
        {
            value = value * value2;
            return value;
        }

    }
}
