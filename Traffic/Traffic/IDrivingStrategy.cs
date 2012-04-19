using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public interface IDrivingStrategy
    {
        double Execute(ICar car, IPlace place, double journeyDuration);
    }
}
