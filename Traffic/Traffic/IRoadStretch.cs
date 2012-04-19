using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public interface IRoadStretch:IPlace
    {
        double GetRoadSpeed();
        double GetRoadStretchLength();
    }
}
